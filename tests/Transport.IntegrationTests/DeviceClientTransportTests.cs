using TestBag.Core;
using TestBag.Transport;

public class DeviceClientTransportTests
{
    [Fact]
    public async Task DeviceClient_ReadsMeasurement_UsingFakeTransport()
    {
        var protocol = new DeviceProtocol();
        var transport = new FakeDeviceTransport(protocol);
        var client = new DeviceClient(transport, protocol);
        await client.ConnectAsync(CancellationToken.None);
        var measurement = await client.ReadMeasurementAsync(CancellationToken.None);
        Assert.Equal(120, measurement.DcCurrent);
        Assert.Equal(240, measurement.DcVoltage);
        await client.DisconnectAsync(CancellationToken.None);
    }
}
