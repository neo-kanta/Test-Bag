using TestBag.Core;

namespace TestBag.Transport;

public sealed class LoopbackTransport(Func<byte[], byte[]> responder) : IDeviceTransport
{
    public event EventHandler<string>? Log;
    public bool IsConnected { get; private set; }

    public Task ConnectAsync(CancellationToken cancellationToken)
    {
        IsConnected = true;
        return Task.CompletedTask;
    }

    public Task DisconnectAsync(CancellationToken cancellationToken)
    {
        IsConnected = false;
        return Task.CompletedTask;
    }

    public Task<byte[]> SendAndReceiveAsync(byte[] payload, TimeSpan timeout, CancellationToken cancellationToken)
    {
        if (!IsConnected) throw new InvalidOperationException("Not connected");
        Log?.Invoke(this, "Loopback transport request");
        return Task.FromResult(responder(payload));
    }
}
