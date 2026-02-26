# TestBag Main Board

## Overview
This board folder stores the current hardware design artifacts. The source-of-truth currently comes from **Altium** files migrated from the legacy repository layout.

## Layout
- `kicad/`: EDA design sources (currently Altium `.SchDoc/.PcbDoc` also stored here until native KiCad migration).
- `libraries/`: custom symbol/footprint/integrated libraries.
- `manufacturing/`: Gerber, drill, pick-and-place, CAM, and release output packages.
- `bom/`: BOM exports and purchasing artifacts.
- `test/testpoints`: test-point maps and expected values.
- `test/fixture`: fixture docs/files for bed-of-nails or harness adapters.
- `test/hil`: hardware-in-loop scripts.

## Connectors / Power / Flashing
- **Power**: verify battery and charging rails from schematic before bring-up.
- **Programming**: ESP32 and MCU programming headers should be validated against the latest schematic.
- **Safety**: use current-limited supply in first bring-up.

## Test strategy
1. Run schematic/ERC and PCB/DRC (`tools/kicad/validate.*`) when KiCad sources are present.
2. Generate manufacturing outputs using `tools/kicad/export.*`.
3. Run HIL smoke via serial command in `test/hil`.
