@echo off
Setlocal enabledelayedexpansion

Set "Pattern=PayGlx"
Set "Replace=Rina90Diet"

For /R %%# in ("*.*") Do (
    Set "File=%%~nx#"
    Ren "%%#" "!File:%Pattern%=%Replace%!"
)
