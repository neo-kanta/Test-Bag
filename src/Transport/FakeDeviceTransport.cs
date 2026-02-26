using System.Text;
using TestBag.Core;

namespace TestBag.Transport;

public sealed class FakeDeviceTransport(IDeviceProtocol protocol) : IDeviceTransport
{
    private bool _connected;
    public event EventHandler<string>? Log;
    public bool IsConnected => _connected;

    public Task ConnectAsync(CancellationToken cancellationToken)
    {
        _connected = true;
        Log?.Invoke(this, "Fake transport connected");
        return Task.CompletedTask;
    }

    public Task DisconnectAsync(CancellationToken cancellationToken)
    {
        _connected = false;
        Log?.Invoke(this, "Fake transport disconnected");
        return Task.CompletedTask;
    }

    public Task<byte[]> SendAndReceiveAsync(byte[] payload, TimeSpan timeout, CancellationToken cancellationToken)
    {
        if (!_connected) throw new InvalidOperationException("Not connected");
        if (!protocol.TryDecode(payload, out var frame)) throw new InvalidOperationException("Bad request packet");

        var response = frame.Command switch
        {
            DeviceCommand.Ping => protocol.Encode(new DeviceFrame(DeviceCommand.Ping, Encoding.UTF8.GetBytes("PONG"))),
            DeviceCommand.ReadMeasurement => protocol.Encode(new DeviceFrame(DeviceCommand.ReadMeasurement, Encoding.UTF8.GetBytes("DC120A|DC240V|AC1.20A|AC230.10V"))),
            _ => throw new NotSupportedException($"Unknown command {frame.Command}")
        };

        return Task.FromResult(response);
    }
}
