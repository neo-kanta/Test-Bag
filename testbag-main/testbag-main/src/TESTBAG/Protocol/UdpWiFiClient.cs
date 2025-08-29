using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTBAG.Protocol
{
    /// <summary>
    /// This class is for receiving data from connected esp32 board with UDP Wi-Fi protocol.
    /// </summary>
    public class UdpWiFiClient : IUdpWiFiClient
    {
        private readonly frmMain _mainDesk;
        private readonly Logger _logger;
        private readonly UdpClient _udpClient;
        private readonly int _retriesDelay = 50;
        private readonly List<Tuple<int, double>> _calibrationPoints;
        private readonly Int16 _udpPort = 8080;
        private readonly object _lockObjectEsp = new object();
        private CancellationTokenSource _cancellationTokenSource;
        public bool StopFlagUdpWiFi => _cancellationTokenSource.IsCancellationRequested;
        private Thread _thdUDPServer;
        public bool _stopFlagUdpWiFi;
        string returnData;

        public delegate void UdpWiFiDataHandler(double currentAcs, double voltageArduino, double currentPzem, double voltagePzem);
        public event UdpWiFiDataHandler UdpWiFiDataReceived;
        public UdpWiFiClient(frmMain mainDesk)
        {
            this._mainDesk = mainDesk;
            _udpClient = new UdpClient();
            _cancellationTokenSource = new CancellationTokenSource();
            _calibrationPoints = new List<Tuple<int, double>>();
            _udpClient.Client.Bind(new IPEndPoint(GetLocalIPAddress(), _udpPort));
        }

        /// <summary>
        /// Get local IP Adress in this computer
        /// </summary>
        public IPAddress GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            throw new Exception("No network adapters with an IPv4 address found!");
        }

        #region SYNC
        /// <summary>
        /// Send the data to esp32 board
        /// </summary>
        public void SendData()
        {
            try
            {
                _udpClient.Connect(GetLocalIPAddress(), _udpPort);

                string hostMessage = "Host Data";
                int sequenceNumber = Convert.ToInt32(_udpClient.Client.LocalEndPoint);

                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                for (int i = 0; i < 5; i++)
                {
                    Byte[] senddata = Encoding.ASCII.GetBytes(hostMessage + ":" + i);
                    _udpClient.Send(senddata, senddata.Length);

                    _udpClient.Client.ReceiveTimeout = 5000; // 5 second timeout

                    Byte[] receiveBytes;
                    try { receiveBytes = _udpClient.Receive(ref RemoteIpEndPoint); }
                    catch (SocketException ex)
                    {
                        if (ex.SocketErrorCode == SocketError.TimedOut)
                        { MessageBox.Show($"No data recieve + {ex}", "Data Recieve ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning); continue; }
                        else { throw; }
                    }
                    finally { _udpClient.Close(); }
                    string returnData = Encoding.ASCII.GetString(receiveBytes);
                    if (returnData == "ACK:" + i) { _logger.HandleError("Packet successfully delivered.+ "); break; }
                    else { if (i == 5 - 1) { _logger.HandleError("Error: Packet not acknowledged."); } else { Thread.Sleep(_retriesDelay); } }
                }
            }
            catch (Exception) { throw; }
        }
        /// <summary>
        /// Let's udp thread start
        /// </summary>
        public void UdpThreadStart()
        {
            _thdUDPServer = new Thread(new ThreadStart(this.UdpThreadTask));
            _thdUDPServer.IsBackground = true;
            _thdUDPServer.Start();
        }

        /// <summary>
        /// Let's udp thread stop
        /// </summary>
        public void UdpThreadStop()
        {
            _stopFlagUdpWiFi = true;
            _thdUDPServer.Join();
        }

        /// <summary>
        /// this upd thread will read data that recieve form esp32 board
        /// </summary>
        private void UdpThreadTask()
        {
            try
            {
                _udpClient.Client.ReceiveBufferSize = 1024;

                while (!_stopFlagUdpWiFi)
                {
                    // - - - - - RECIEVER DATA FROM ESP32 - - - - - //
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, _udpPort);
                    Byte[] recieveBytes;
                    try { recieveBytes = _udpClient.Receive(ref RemoteIpEndPoint); }
                    catch (SocketException ex)
                    {
                        if (ex.SocketErrorCode == SocketError.WouldBlock) { continue; }
                        else { throw; }
                    }
                    returnData = Encoding.ASCII.GetString(recieveBytes);

                    // - - - - - - -  SEND ACKNOWLEDGEMENT TO THE SENDER - - - - - - //
                    //Byte[] sendBytes = Encoding.ASCII.GetBytes("ACK");    
                    //udpClient.Send(sendBytes, sendBytes.Length, RemoteIpEndPoint);

                    string[] dataParts = returnData.Split(':');
                    if (dataParts.Length > 1 && int.TryParse(dataParts[1], out int sequenceNumber))
                    {
                        Byte[] sendBytes = Encoding.ASCII.GetBytes("ACK:" + sequenceNumber);
                        _udpClient.Send(sendBytes, sendBytes.Length, RemoteIpEndPoint);
                    }

                    // - - - - - - -  RAW DATA OF ESP32 - - - - - - //
                    var wifiData = DataPattern.GetDataEsp(returnData.ToString());
                    double currentAcs = wifiData.currentDc;
                    double voltageArduino = wifiData.voltageDc;
                    double currentPzem = wifiData.currentAc;
                    double voltagePzem = wifiData.voltageAc;

                    //double physicalVoltage = (voltageArduino / 4095 ) *24;
                    double physicalVoltage = (voltageArduino / 3926) * 3.3 * 5;
                    double voltageReferenceAcs = (voltageArduino / 4095.0) * 3.3;
                    double voltageDifference = voltageReferenceAcs - 2.5;
                    double physicalCurrent = voltageDifference / 0.185;

                    if (UdpWiFiDataReceived != null) { UdpWiFiDataReceived(physicalCurrent, physicalVoltage, currentPzem, voltagePzem); }
                }
            }
            catch (SocketException ex) { MessageBox.Show($"Error: Invalid IP address or port number:{ex.Message}"); Dispose(); }
            catch (FormatException ex) { MessageBox.Show($"Error: Invalid IP address or port number:{ex.Message}"); Dispose(); }
            catch (ArgumentNullException ex) { MessageBox.Show($"Error: Message is null: {ex.Message}"); Dispose(); }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message); }
            finally { Dispose(); }
        }
        public string UdpReceive()
        {
            try
            {
                _udpClient.Client.ReceiveBufferSize = 1024;
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, _udpPort);
                Byte[] recieveBytes;
                recieveBytes = _udpClient.Receive(ref RemoteIpEndPoint);
                returnData = Encoding.ASCII.GetString(recieveBytes);
                return returnData;

            }
            catch (Exception ex) { throw new ArgumentException($"Device {ex} not found in the list of discovered devices."); }
            finally { Dispose(); }
        }
        #endregion SYNC

        #region ASYNC 

        /// <summary>
        /// Async Send data to esp32 board.
        /// </summary>
        public async Task SendDataAsync()
        {
            try
            {
                _udpClient.Connect(GetLocalIPAddress(), _udpPort);
                string hostMessage = "Host Data";

                for (int i = 0; i < 5; i++)
                {
                    await SendDataWithRetriesAsync(hostMessage, i);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private async Task SendDataWithRetriesAsync(string hostMessage, int sequenceNumber)
        {
            for (int i = 0; i < 5; i++)
            {
                bool success = await SendDataWithTimeoutAsync(hostMessage, sequenceNumber);

                if (success)
                {
                    _logger.HandleError("Packet successfully delivered.");
                    break;
                }
                else
                {
                    if (i == 5 - 1)
                    {
                        _logger.HandleError("Error: Packet not acknowledged.");
                    }
                    else
                    {
                        await Task.Delay(_retriesDelay);
                    }
                }
            }
        }

        private async Task<bool> SendDataWithTimeoutAsync(string hostMessage, int sequenceNumber)
        {
            byte[] sendData = Encoding.ASCII.GetBytes($"{hostMessage}:{sequenceNumber}");
            await _udpClient.SendAsync(sendData, sendData.Length);

            _udpClient.Client.ReceiveTimeout = 5000; // 5-second timeout

            try
            {
                UdpReceiveResult receiveResult = await _udpClient.ReceiveAsync();
                string returnData = Encoding.ASCII.GetString(receiveResult.Buffer);
                return returnData == $"ACK:{sequenceNumber}";
            }
            catch (SocketException ex)
            {
                if (ex.SocketErrorCode == SocketError.TimedOut)
                {
                    MessageBox.Show($"No data received: {ex}", "Data Receive ", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Start the UDP listener task.
        /// </summary>
        public async Task UdpListenerStartAsync()
        {
            await UdpListenerTask(_cancellationTokenSource.Token);
        }

        /// <summary>
        /// Stop the UDP listener task.
        /// </summary>
        public void UdpListenerStop()
        {
            _cancellationTokenSource.Cancel();
        }

        /// <summary>
        /// UDP listener task to read data received from the esp32 board.
        /// </summary>
        public async Task UdpListenerTask(CancellationToken cancellationToken)
        {
            try
            {
                _udpClient.Client.ReceiveBufferSize = 1024;

                while (!cancellationToken.IsCancellationRequested)
                {
                    IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, _udpPort);
                    UdpReceiveResult receiveResult = await _udpClient.ReceiveAsync();

                    string receivedData = Encoding.ASCII.GetString(receiveResult.Buffer);

                    string[] dataParts = receivedData.Split(':');
                    if (dataParts.Length > 1 && int.TryParse(dataParts[1], out int sequenceNumber))
                    {
                        byte[] sendBytes = Encoding.ASCII.GetBytes($"ACK:{sequenceNumber}");
                        await _udpClient.SendAsync(sendBytes, sendBytes.Length);
                    }

                    var wifiData = DataPattern.GetDataEsp(receivedData);
                    double currentAcs = wifiData.currentDc;
                    double voltageArduino = wifiData.voltageDc;
                    double currentPzem = wifiData.currentAc;
                    double voltagePzem = wifiData.voltageAc;

                    double physicalVoltage = (voltageArduino / 3926) * 3.3 * 5;
                    double voltageReferenceAcs = (voltageArduino / 4095.0) * 3.3;
                    double voltageDifference = voltageReferenceAcs - 2.5;
                    double physicalCurrent = voltageDifference / 0.185;

                    UdpWiFiDataReceived?.Invoke(physicalCurrent, physicalVoltage, currentPzem, voltagePzem);
                }
            }
            catch (SocketException ex) { MessageBox.Show($"Error: Invalid IP address or port number:{ex.Message}"); Dispose(); }
            catch (FormatException ex) { MessageBox.Show($"Error: Invalid IP address or port number:{ex.Message}"); Dispose(); }
            catch (ArgumentNullException ex) { MessageBox.Show($"Error: Message is null: {ex.Message}"); Dispose(); }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message); }
            finally { Dispose(); }
        }
        public async Task<string[]> UdpReceiveData()
        {
            _udpClient.Client.ReceiveBufferSize = 1024;
            IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, _udpPort);
            UdpReceiveResult receiveResult = await _udpClient.ReceiveAsync();
            string receivedData = Encoding.ASCII.GetString(receiveResult.Buffer);
            string[] dataParts = receivedData.Split(':');
            if (dataParts != null)
            {
                return dataParts;
            }
            else
            {
                throw new Exception(nameof(dataParts)); ;
            }
        }
        public string globalreturndata;
        public async Task<string> UdpReceiveDataAsync(CancellationToken cancellationToken)
        {
            try
            {
                if (_udpClient == null)
                {
                    throw new InvalidOperationException("UdpClient is not initialized.");
                }
                await Task.Run(() =>
                {
                    _udpClient.Client.ReceiveBufferSize = 1024;
                    IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, _udpPort);
                    cancellationToken.ThrowIfCancellationRequested();
                    Byte[] recieveBytes;

                    recieveBytes = _udpClient.Receive(ref remoteIpEndPoint);


                    string returnData = Encoding.ASCII.GetString(recieveBytes);
                    string[] returnDataParse = returnData.Split(':');

                    if (returnDataParse == null || returnDataParse.Length == 0)
                    {
                        throw new Exception("Received data is invalid.");
                    }
                    globalreturndata = returnData;
                    return returnData;
                });
                return globalreturndata;
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while receiving data.", ex);
            }
        }
        public async Task<string> UdpReceiveDataAsyncNoCancle()
        {
            try
            {
                if (_udpClient == null)
                {
                    throw new InvalidOperationException("UdpClient is not initialized.");
                }
                await Task.Run(() =>
                {
                    _udpClient.Client.ReceiveBufferSize = 1024;
                    IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, _udpPort);
                    Byte[] recieveBytes;

                    recieveBytes = _udpClient.Receive(ref remoteIpEndPoint);


                    string returnData = Encoding.ASCII.GetString(recieveBytes);
                    string[] returnDataParse = returnData.Split(':');

                    if (returnDataParse == null || returnDataParse.Length == 0)
                    {
                        throw new Exception("Received data is invalid.");
                    }
                    globalreturndata = returnData;
                    return returnData;
                });
                return globalreturndata;
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while receiving data.", ex);
            }
        }
        #endregion ASYNC 

        public void Dispose()
        {
            _udpClient?.Dispose();
            _udpClient?.Close();
            _cancellationTokenSource?.Dispose();
        }
    }
}