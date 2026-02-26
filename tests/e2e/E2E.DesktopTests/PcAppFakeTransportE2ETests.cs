using System.Diagnostics;

public class PcAppFakeTransportE2ETests
{
    [Fact]
    public async Task PcApp_TransitionsState_WithFakeDevice()
    {
        var startInfo = new ProcessStartInfo("dotnet", "run --project apps/pc-cli/PcApp.csproj -- --device=fake")
        {
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            WorkingDirectory = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../../.."))
        };

        using var process = Process.Start(startInfo)!;
        var output = await process.StandardOutput.ReadToEndAsync();
        await process.WaitForExitAsync();

        Assert.Equal(0, process.ExitCode);
        Assert.Contains("State: Disconnected", output);
        Assert.Contains("State: Connected", output);
        Assert.Contains("Measurement:", output);
    }
}
