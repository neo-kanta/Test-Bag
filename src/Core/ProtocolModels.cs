namespace TestBag.Core;

public enum DeviceCommand : byte
{
    Ping = 0x01,
    ReadMeasurement = 0x02,
    SetRelay = 0x03,
}

public sealed record DeviceFrame(DeviceCommand Command, byte[] Payload);

public sealed record Measurement(int DcCurrent, int DcVoltage, decimal AcCurrent, decimal AcVoltage);
