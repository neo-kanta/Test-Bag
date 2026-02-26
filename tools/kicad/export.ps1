param([string]$BoardRoot = "hardware/pcb/testbag-main-board")
$boardDir = Join-Path $BoardRoot "kicad"
$manDir = Join-Path $BoardRoot "manufacturing"
$bomDir = Join-Path $BoardRoot "bom"
New-Item -ItemType Directory -Force -Path $manDir,$bomDir | Out-Null
if (-not (Get-Command kicad-cli -ErrorAction SilentlyContinue)) {
  Write-Host "kicad-cli not found; skipping PCB export."
  exit 0
}
$pcb = Get-ChildItem -Path $boardDir -Recurse -Filter *.kicad_pcb | Select-Object -First 1
$sch = Get-ChildItem -Path $boardDir -Recurse -Filter *.kicad_sch | Select-Object -First 1
if (-not $pcb -or -not $sch) {
  Write-Host "KiCad sources not found; skipping export."
  exit 0
}
kicad-cli pcb export gerbers -o $manDir $pcb.FullName
kicad-cli pcb export drill -o $manDir $pcb.FullName
kicad-cli pcb export pos -o $manDir $pcb.FullName
kicad-cli sch export python-bom -o (Join-Path $bomDir "bom.xml") $sch.FullName
