@echo on
TASKKILL /IM wscript.exe /F
TASKKILL /IM node.exe /F
@echo off
set /p id="Do You Want To Also Close Chrome (Y/N): "
if %id%==Y (
    TASKKILL /IM chrome.exe /F
    PAUSE
)
if %id%==y (
    TASKKILL /IM chrome.exe /F
    PAUSE
)
TASKKILL /IM conhost.exe /F
