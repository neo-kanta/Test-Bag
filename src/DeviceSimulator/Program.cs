using System.Text;
using TestBag.Core;

var protocol = new DeviceProtocol();
Console.WriteLine("Device simulator started. Paste hex packet bytes, one line each.");
while (true)
{
    var line = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(line)) continue;

    var bytes = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => Convert.ToByte(x, 16)).ToArray();
    if (!protocol.TryDecode(bytes, out var frame))
    {
        Console.WriteLine("ERR decode");
        continue;
    }

    var response = frame.Command == DeviceCommand.ReadMeasurement
        ? protocol.Encode(new DeviceFrame(DeviceCommand.ReadMeasurement, Encoding.UTF8.GetBytes("DC130A|DC250V|AC1.15A|AC228.75V")))
        : protocol.Encode(new DeviceFrame(frame.Command, Encoding.UTF8.GetBytes("OK")));
    Console.WriteLine(string.Join(" ", response.Select(b => b.ToString("X2"))));
}
