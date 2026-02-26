using System.Text.Json;
using TestBag.Core;
using TestBag.Transport;

var configPath = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
var json = File.Exists(configPath) ? File.ReadAllText(configPath) : "{}";
using var doc = JsonDocument.Parse(json);
var defaultMode = doc.RootElement.GetProperty("Device").GetProperty("Mode").GetString() ?? "fake";
var mode = args.FirstOrDefault(a => a.StartsWith("--device="))?.Split('=')[1] ?? defaultMode;

var protocol = new DeviceProtocol();
IDeviceTransport transport = mode.Equals("fake", StringComparison.OrdinalIgnoreCase)
    ? new FakeDeviceTransport(protocol)
    : throw new NotSupportedException("Only fake transport is wired in this baseline refactor.");

var client = new DeviceClient(transport, protocol);
using var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));

Console.WriteLine("State: Disconnected");
await client.ConnectAsync(cts.Token);
Console.WriteLine("State: Connected");

var measurement = await client.ReadMeasurementAsync(cts.Token);
Console.WriteLine($"Measurement: DC {measurement.DcCurrent}A {measurement.DcVoltage}V | AC {measurement.AcCurrent}A {measurement.AcVoltage}V");

await client.DisconnectAsync(cts.Token);
Console.WriteLine("State: Disconnected");
