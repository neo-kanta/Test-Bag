#!/usr/bin/env bash
set -euo pipefail
BOARD_ROOT=${1:-hardware/pcb/testbag-main-board}
BOARD_DIR="$BOARD_ROOT/kicad"
MAN_DIR="$BOARD_ROOT/manufacturing"
BOM_DIR="$BOARD_ROOT/bom"
mkdir -p "$MAN_DIR" "$BOM_DIR"

if ! command -v kicad-cli >/dev/null 2>&1; then
  echo "kicad-cli not found; skipping PCB export."
  exit 0
fi

PCB_FILE=$(find "$BOARD_DIR" -maxdepth 2 -type f -name "*.kicad_pcb" | head -n1 || true)
SCH_FILE=$(find "$BOARD_DIR" -maxdepth 2 -type f -name "*.kicad_sch" | head -n1 || true)

if [[ -z "$PCB_FILE" || -z "$SCH_FILE" ]]; then
  echo "KiCad source files not found; skipping export."
  exit 0
fi

kicad-cli pcb export gerbers -o "$MAN_DIR" "$PCB_FILE"
kicad-cli pcb export drill -o "$MAN_DIR" "$PCB_FILE"
kicad-cli pcb export pos -o "$MAN_DIR" "$PCB_FILE"
kicad-cli sch export python-bom -o "$BOM_DIR/bom.xml" "$SCH_FILE" || true
