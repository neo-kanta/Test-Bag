# Test-Bag Monorepo

Professionalized monorepo structure for PC software, firmware, simulator, tests, and hardware artifacts.

## Repository layout

```text
.
├─ apps/
│  ├─ pc-cli/
│  └─ pc-legacy-winforms/
├─ libs/
│  ├─ core/
│  └─ transport/
├─ simulators/
│  └─ device-simulator/
├─ firmware/
│  ├─ arduino-ac/
│  └─ esp32/
│     ├─ espwifi/
│     └─ espwitheadc/
├─ hardware/
│  └─ pcb/
│     └─ testbag-main-board/
│        ├─ kicad/
│        ├─ libraries/
│        ├─ manufacturing/
│        ├─ bom/
│        └─ test/
│           ├─ testpoints/
│           ├─ fixture/
│           └─ hil/
├─ tests/
│  ├─ unit/
│  ├─ integration/
│  ├─ e2e/
│  └─ hil/
├─ tools/
│  └─ kicad/
└─ docs/
```

## Inventory
- New .NET baseline projects:
  - `libs/core`, `libs/transport`, `apps/pc-cli`, `simulators/device-simulator`
- Legacy WinForms:
  - `apps/pc-legacy-winforms` (.NET Framework 4.8; Windows-only)
- Firmware PlatformIO:
  - `firmware/arduino-ac`, `firmware/esp32/espwifi`, `firmware/esp32/espwitheadc`
- PCB folder:
  - `hardware/pcb/testbag-main-board/kicad` currently contains migrated **Altium** sources and related design assets.
  - `hardware/pcb/testbag-main-board/manufacturing` contains generated outputs.

## Build / run commands

### .NET baseline
```bash
dotnet build TestBag.sln
dotnet run --project apps/pc-cli/PcApp.csproj -- --device=fake
```

### .NET tests
```bash
dotnet test tests/unit/Core.UnitTests/Core.UnitTests.csproj
dotnet test tests/integration/Transport.IntegrationTests/Transport.IntegrationTests.csproj
dotnet test tests/e2e/E2E.DesktopTests/E2E.DesktopTests.csproj
```

### Firmware builds
```bash
platformio run -d firmware/arduino-ac
platformio run -d firmware/esp32/espwifi
platformio run -d firmware/esp32/espwitheadc
```

### PCB checks / export (optional)
```bash
bash tools/kicad/validate.sh hardware/pcb/testbag-main-board/kicad
bash tools/kicad/export.sh hardware/pcb/testbag-main-board
```

If `kicad-cli` is unavailable, scripts print a clear skip message and exit successfully.

## Legacy app
Open `apps/pc-legacy-winforms/TESTBAG.sln` in Visual Studio on Windows.
