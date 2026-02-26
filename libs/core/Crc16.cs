namespace TestBag.Core;

public static class Crc16
{
    public static ushort Compute(ReadOnlySpan<byte> data)
    {
        ushort crc = 0xFFFF;
        foreach (var b in data)
        {
            crc ^= b;
            for (var i = 0; i < 8; i++)
            {
                crc = (ushort)((crc & 1) == 1 ? (crc >> 1) ^ 0xA001 : crc >> 1);
            }
        }

        return crc;
    }
}
