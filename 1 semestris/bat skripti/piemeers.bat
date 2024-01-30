@echo off
REM Comment
set var_name=value
echo %var_name%
set /p input=Ievadi vērtību
echo %input%
REM set /a rez=input*2
echo.
set /a rez=%input%*2
echo 
:11:
pause
call 1.bat
rem goto :11:
rem append with >>
rem > overwrites
rem or (
rem echo.
rem echo.
rem ) > file.txt
rem type file.txt