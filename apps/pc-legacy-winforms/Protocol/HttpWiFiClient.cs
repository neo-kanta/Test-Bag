using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Threading.Tasks;
using Zeroconf;

namespace TESTBAG.Protocol
{
    /// <summary>
    /// Manages and maintain using HTTP Protocol to maintain ESP32 SSID and PASSWORD without hardcoding.
    /// </summary>
    public class HttpWiFiClient : IHttpWiFiClient
    {
        private readonly HttpClient _httpClient;
        private const string esp32BaseUrl = "http://esp32.local";
        private Dictionary<string, (string ipAddress, string macAddress)> _esp32Devices;

        private string _esp32BaseUrl;

        public event EventHandler ConnectionLost;
        public event EventHandler ConnectionEstablished;
        public event EventHandler<ConnectionStatusEventArgs> ConnectionStatusChanged;
        public event EventHandler<List<(ConnectionStatus, bool, bool, bool)>> CheckAllStatus;
        public event EventHandler<List<(bool, bool)>> PinStatusCheck;
        public event EventHandler<List<(string, string, string)>> Esp32DevicesDiscovered;

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpWiFiClient"/> class.
        /// </summary>
        /// <param name="httpClient">The path to the registry key.</param>
        public HttpWiFiClient(HttpClient httpClient)
        {
            this._httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _esp32Devices = new Dictionary<string, (string ipAddress, string macAddress)>();
        }
        private string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        public async Task<bool> SetUdpTargetAsync()
        {
            var postData = new Dictionary<string, string>
            {
                { "ip", GetLocalIPAddress() },
                { "port", Properties.Settings.Default.UDP_Port }
            };

            try
            {
                var response = await _httpClient.PostAsync($"{esp32BaseUrl}/setudptarget", new FormUrlEncodedContent(postData)).ConfigureAwait(false);
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }
        public async Task<bool> SendLocalIPAddressAsync()
        {
            string localIPAddress = GetLocalIPAddress();
            string requestUrl = $"{_esp32BaseUrl}/setudptarget?ip={localIPAddress}&port=8888"; // Replace 8888 with the desired port

            try
            {
                var response = await _httpClient.GetAsync(requestUrl).ConfigureAwait(false);
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }



        /// <summary>
        /// Send the data to maintain ssid and password of esp32
        /// </summary>
        /// <param name="ssid">The controls whose data will be maintain ssid of esp32.</param>
        /// <param name="password">The controls whose data will be maintain password of esp32.</param>
        public async Task<bool> SendWiFiCredentialsAsync(string ssid, string password)
        {
            if (string.IsNullOrWhiteSpace(ssid)) throw new ArgumentNullException(nameof(ssid));
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentNullException(nameof(password));

            var postData = new Dictionary<string, string>
            {
                { "ssid", ssid },
                { "password", password }
            };

            try
            {
                var response = await _httpClient.PostAsync($"{esp32BaseUrl}/setwifi", new FormUrlEncodedContent(postData)).ConfigureAwait(false);
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException)
            {
                return false;
            }
        }

        /// <summary>
        /// Use to get data async from esp32 board
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetDataAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync($"{esp32BaseUrl}/getdata").ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return null;
                }
            }
            catch (HttpRequestException)
            {
                return null;
            }
        }

        /// <summary>
        /// Send the data to maintain ssid and password of esp32
        /// </summary>
        /// <param name="ssid">The controls used ssid to check wifi connection esp32.</param>
        /// <param name="password">The controls used password to check wifi connection esp32.</param>
        public async Task<bool> CheckWiFiConnectionAsync(string ssid, string pwd)
        {
            int retryCount = 3;
            ConnectionStatus connectionStatus = ConnectionStatus.Disconnected;
            for (int i = 0; i < retryCount; i++)
            {
                try
                {
                    await GetPinStatusAsync();
                    //var response = await _httpClient.GetAsync($"{esp32BaseUrl}/checkwifi").ConfigureAwait(false);
                    var response = await _httpClient.GetAsync($"{esp32BaseUrl}/checkallstatus").ConfigureAwait(false);

                    if (response.IsSuccessStatusCode)
                    {
                        string connectionStatusString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        if (connectionStatusString.Equals("connected", StringComparison.OrdinalIgnoreCase))
                        {
                            connectionStatus = ConnectionStatus.Connected;
                            break;
                            //return true;
                        }
                    }
                }
                catch (HttpRequestException)
                {
                    await Task.Delay(TimeSpan.FromSeconds(1)).ConfigureAwait(false);
                }

                if (i == retryCount - 1)
                {
                    connectionStatus = ConnectionStatus.Disconnected;
                    ConnectionLost?.Invoke(this, EventArgs.Empty);
                    await SendWiFiCredentialsAsync(ssid, pwd).ConfigureAwait(false);
                }
            }
            ConnectionStatusChanged?.Invoke(this, new ConnectionStatusEventArgs(connectionStatus));
            return connectionStatus == ConnectionStatus.Connected;
            //return false;
        }

        public async Task<(ConnectionStatus connection, bool connectionStatus, bool ledStatus, bool relayStatus)> GetEntireStatus()
        {
            try
            {
                var response = await _httpClient.GetAsync($"{esp32BaseUrl}/checkallstatus").ConfigureAwait(false);
                ConnectionStatus connectingStatus = ConnectionStatus.Connecting;

                if (response.IsSuccessStatusCode)
                {
                    var statusString = await response.Content.ReadAsStringAsync();
                    var statusData = statusString.Split(',');

                    bool connectionStatusData = statusData[0].Split(':')[1] == "1";
                    bool ledStatusData = statusData[1].Split(':')[1] == "1";
                    bool relayStatusData = statusData[2].Split(':')[1] == "1";

                    if (connectionStatusData == true)
                    {
                        connectingStatus = ConnectionStatus.Connected;

                    }
                    else
                    {
                        connectingStatus = ConnectionStatus.Disconnected;
                    }
                    var statusList = new List<(ConnectionStatus, bool, bool, bool)> { (connectingStatus, connectionStatusData, ledStatusData, relayStatusData) };
                    CheckAllStatus?.Invoke(this, statusList);
                    return (connectingStatus, connectionStatusData, ledStatusData, relayStatusData);
                }
                else
                {
                    return (ConnectionStatus.Disconnected, false, false, false);
                }
            }
            catch (HttpRequestException)
            {
                return (ConnectionStatus.Disconnected, false, false, false);
            }
        }
        public async Task<(bool ledStatus, bool relayStatus)> GetPinStatusAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync($"{esp32BaseUrl}/pinstatus").ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    var pinStatusString = await response.Content.ReadAsStringAsync();
                    var statusValues = pinStatusString.Split(',');

                    bool ledStatus = statusValues[0].Split(':')[1] == "1";
                    bool relayStatus = statusValues[1].Split(':')[1] == "1";

                    var pinStatusList = new List<(bool, bool)> { (ledStatus, relayStatus) };
                    PinStatusCheck?.Invoke(this, pinStatusList);
                    return (ledStatus, relayStatus);
                }
                else
                {
                    //ConnectionStatusChanged?.Invoke(this, new ConnectionStatusEventArgs.Empty);
                    return (false, false);
                }
            }
            catch (HttpRequestException)
            {
                return (false, false);
            }

        }
        /// <summary>
        /// Discover ESP32 Device
        /// </summary>
        /// <returns></returns>
        public async Task DiscoverEspAsync()
        {
            IReadOnlyList<IZeroconfHost> results = await ZeroconfResolver.ResolveAsync("_http._tcp.local.").ConfigureAwait(false);

            List<(string, string, string)> deviceInfoList = new List<(string, string, string)>();

            foreach (IZeroconfHost host in results)
            {
                if (host.DisplayName.StartsWith("esp32", StringComparison.OrdinalIgnoreCase))
                {
                    string ipAddress = host.IPAddress;
                    string displayName = host.DisplayName;
                    string macAddress = host.Id;

                    if (host.DisplayName.StartsWith("esp32", StringComparison.OrdinalIgnoreCase))
                    {
                        if (!_esp32Devices.ContainsKey(displayName))
                        {
                            _esp32Devices.Add(displayName, (ipAddress, macAddress));
                        }
                        Esp32DevicesDiscovered?.Invoke(this, (deviceInfoList));
                    }
                    deviceInfoList.Add((displayName, ipAddress, macAddress));
                }
            }
            Esp32DevicesDiscovered?.Invoke(this, deviceInfoList);
        }


        /// <summary>
        /// Set base URL of Device that connect as HTTP
        /// </summary>
        /// <param name="deviceName"></param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public void SetBaseUrlByDeviceName(string deviceName)
        {
            if (string.IsNullOrWhiteSpace(deviceName))
                throw new ArgumentNullException(nameof(deviceName));

            if (!_esp32Devices.ContainsKey(deviceName))
                throw new ArgumentException($"Device {deviceName} not found in the list of discovered devices.");

            _esp32BaseUrl = $"http://{_esp32Devices[deviceName].Item1}";
        }

        /// <summary>
        /// Set index of base URL of Device that connect as HTTP
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void SetBaseUrlByDeviceIndex(int index)
        {
            if (index < 0 || index >= _esp32Devices.Count)
                throw new ArgumentOutOfRangeException(nameof(index));

            var deviceName = _esp32Devices.Keys.ElementAt(index);
            _esp32BaseUrl = $"http://{_esp32Devices[deviceName].Item1}";
        }

        /// <summary>
        /// Toggle LED in the ESP32
        /// </summary>
        /// <param name="ledPin"></param>
        /// <returns></returns>
        public async Task<string> ToggleLedAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync($"{esp32BaseUrl}/toggleled").ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return null;
                }
            }
            catch (HttpRequestException)
            {
                return null;
            }
            catch (TaskCanceledException)
            {
                return null;
            }
        }

        public async Task<string> ToggleRelayAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync($"{esp32BaseUrl}/togglerelay").ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    return null;
                }
            }
            catch (HttpRequestException)
            {
                return null;
            }
            catch (TaskCanceledException)
            {
                return null;
            }
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}