namespace TestBag.Core;

public interface IDeviceProtocol
{
    byte[] Encode(DeviceFrame frame);
    bool TryDecode(ReadOnlySpan<byte> packet, out DeviceFrame frame);
}
