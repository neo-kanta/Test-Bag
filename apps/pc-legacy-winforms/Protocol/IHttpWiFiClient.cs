using System;
using System.Threading.Tasks;

namespace TESTBAG.Protocol
{
    public interface IHttpWiFiClient : IDisposable
    {
        Task<bool> SendWiFiCredentialsAsync(string username, string password);
        Task<string> GetDataAsync();
        Task<bool> CheckWiFiConnectionAsync(string ssid, string pwd);
        Task<(bool ledStatus, bool relayStatus)> GetPinStatusAsync();
        Task DiscoverEspAsync();
        void SetBaseUrlByDeviceName(string deviceName);
        void SetBaseUrlByDeviceIndex(int index);
        Task<string> ToggleLedAsync();
        Task<string> ToggleRelayAsync();
    }
}