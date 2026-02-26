# HIL tests

Hardware-in-loop tests are intentionally separated from CI default runs.

## Local run
1. Build/flash firmware (`firmware/esp32/espwifi` or `firmware/arduino-ac`).
2. Install dependency:
   - `pip install pyserial`
3. Run smoke test:
   - `python hardware/pcb/testbag-main-board/test/hil/test_serial_smoke.py --port COM5`

## Notes
- HIL requires real hardware and safe lab setup.
- Save serial logs for triage.
