param([string]$BoardDir = "hardware/pcb/testbag-main-board/kicad")
if (-not (Get-Command kicad-cli -ErrorAction SilentlyContinue)) {
  Write-Host "kicad-cli not found; skipping PCB validation."
  exit 0
}
$sch = Get-ChildItem -Path $BoardDir -Recurse -Include *.kicad_sch,*.SchDoc | Select-Object -First 1
$pcb = Get-ChildItem -Path $BoardDir -Recurse -Include *.kicad_pcb,*.PcbDoc | Select-Object -First 1
if (-not $sch -or -not $pcb) {
  Write-Host "No KiCad schematic/PCB found; skipping validation."
  exit 0
}
kicad-cli sch erc $sch.FullName
kicad-cli pcb drc $pcb.FullName
