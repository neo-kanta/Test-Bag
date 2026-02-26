namespace TestBag.Core;

public interface IDeviceClient
{
    Task ConnectAsync(CancellationToken cancellationToken);
    Task DisconnectAsync(CancellationToken cancellationToken);
    Task<Measurement> ReadMeasurementAsync(CancellationToken cancellationToken);
}
