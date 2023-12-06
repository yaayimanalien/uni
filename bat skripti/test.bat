@echo off
setlocal enabledelayedexpansion

rem Sample variable
set myVariable=Hello

rem Get the first character
set firstCharacter=!myVariable:~1,2!

echo First character: %firstCharacter%

endlocal