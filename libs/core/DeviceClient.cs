namespace TestBag.Core;

public interface IDeviceTransport
{
    event EventHandler<string>? Log;
    bool IsConnected { get; }
    Task ConnectAsync(CancellationToken cancellationToken);
    Task DisconnectAsync(CancellationToken cancellationToken);
    Task<byte[]> SendAndReceiveAsync(byte[] payload, TimeSpan timeout, CancellationToken cancellationToken);
}

public sealed class DeviceClient(IDeviceTransport transport, IDeviceProtocol protocol) : IDeviceClient
{
    public async Task ConnectAsync(CancellationToken cancellationToken) => await transport.ConnectAsync(cancellationToken);

    public async Task DisconnectAsync(CancellationToken cancellationToken) => await transport.DisconnectAsync(cancellationToken);

    public async Task<Measurement> ReadMeasurementAsync(CancellationToken cancellationToken)
    {
        var request = protocol.Encode(new DeviceFrame(DeviceCommand.ReadMeasurement, []));
        var response = await transport.SendAndReceiveAsync(request, TimeSpan.FromSeconds(1), cancellationToken);
        if (!protocol.TryDecode(response, out var frame) || frame.Command != DeviceCommand.ReadMeasurement)
        {
            throw new InvalidOperationException("Protocol decode failed.");
        }

        var text = System.Text.Encoding.UTF8.GetString(frame.Payload);
        // DC123A|DC456V|AC1.23A|AC228.10V
        var chunks = text.Split('|', StringSplitOptions.RemoveEmptyEntries);
        return new Measurement(
            int.Parse(chunks[0].Replace("DC", string.Empty).Replace("A", string.Empty)),
            int.Parse(chunks[1].Replace("DC", string.Empty).Replace("V", string.Empty)),
            decimal.Parse(chunks[2].Replace("AC", string.Empty).Replace("A", string.Empty)),
            decimal.Parse(chunks[3].Replace("AC", string.Empty).Replace("V", string.Empty)));
    }
}
