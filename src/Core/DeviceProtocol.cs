using System.Buffers.Binary;

namespace TestBag.Core;

public sealed class DeviceProtocol : IDeviceProtocol
{
    private const byte Stx = 0x02;
    private const byte Etx = 0x03;

    public byte[] Encode(DeviceFrame frame)
    {
        var payloadLength = (byte)frame.Payload.Length;
        var bodyLength = 2 + payloadLength;
        var body = new byte[bodyLength];
        body[0] = (byte)frame.Command;
        body[1] = payloadLength;
        frame.Payload.CopyTo(body.AsSpan(2));

        var crc = Crc16.Compute(body);
        var packet = new byte[1 + bodyLength + 2 + 1];
        packet[0] = Stx;
        body.CopyTo(packet, 1);
        BinaryPrimitives.WriteUInt16LittleEndian(packet.AsSpan(1 + bodyLength, 2), crc);
        packet[^1] = Etx;
        return packet;
    }

    public bool TryDecode(ReadOnlySpan<byte> packet, out DeviceFrame frame)
    {
        frame = default!;
        if (packet.Length < 6 || packet[0] != Stx || packet[^1] != Etx)
        {
            return false;
        }

        var command = packet[1];
        var payloadLength = packet[2];
        var expected = 1 + 2 + payloadLength + 2 + 1;
        if (packet.Length != expected)
        {
            return false;
        }

        var body = packet.Slice(1, 2 + payloadLength);
        var expectedCrc = BinaryPrimitives.ReadUInt16LittleEndian(packet.Slice(1 + body.Length, 2));
        if (Crc16.Compute(body) != expectedCrc)
        {
            return false;
        }

        var payload = packet.Slice(3, payloadLength).ToArray();
        frame = new DeviceFrame((DeviceCommand)command, payload);
        return true;
    }
}
