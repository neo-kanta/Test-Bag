using TestBag.Core;

public class ProtocolTests
{
    [Fact]
    public void EncodeDecode_RoundTrips()
    {
        var protocol = new DeviceProtocol();
        var packet = protocol.Encode(new DeviceFrame(DeviceCommand.Ping, [0x10, 0x20]));
        var ok = protocol.TryDecode(packet, out var frame);
        Assert.True(ok);
        Assert.Equal(DeviceCommand.Ping, frame.Command);
        Assert.Equal(new byte[] { 0x10, 0x20 }, frame.Payload);
    }

    [Fact]
    public void Decode_Fails_WhenCrcInvalid()
    {
        var protocol = new DeviceProtocol();
        var packet = protocol.Encode(new DeviceFrame(DeviceCommand.Ping, [0x10]));
        packet[3] = 0xFF;
        Assert.False(protocol.TryDecode(packet, out _));
    }
}
