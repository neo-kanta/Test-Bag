using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace TESTBAG.Protocol
{
    public interface IUdpWiFiClient : IDisposable
    {
        IPAddress GetLocalIPAddress();
        void SendData();
        Task SendDataAsync();
        Task UdpListenerStartAsync();
        void UdpListenerStop();
        Task UdpListenerTask(CancellationToken cancellationToken);
        Task<string[]> UdpReceiveData();
    }
}
