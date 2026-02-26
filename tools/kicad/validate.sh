#!/usr/bin/env bash
set -euo pipefail
BOARD_DIR=${1:-hardware/pcb/testbag-main-board/kicad}
SCH_FILE=$(find "$BOARD_DIR" -maxdepth 2 -type f \( -name "*.kicad_sch" -o -name "*.SchDoc" \) | head -n1 || true)
PCB_FILE=$(find "$BOARD_DIR" -maxdepth 2 -type f \( -name "*.kicad_pcb" -o -name "*.PcbDoc" \) | head -n1 || true)

if ! command -v kicad-cli >/dev/null 2>&1; then
  echo "kicad-cli not found; skipping PCB validation."
  exit 0
fi

if [[ -z "$SCH_FILE" || -z "$PCB_FILE" ]]; then
  echo "No KiCad schematic/PCB found in $BOARD_DIR; skipping validation."
  exit 0
fi

kicad-cli sch erc "$SCH_FILE"
kicad-cli pcb drc "$PCB_FILE"
