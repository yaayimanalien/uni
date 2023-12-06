@echo off

:start
set /p input="Ievadi A, B, C vai D: "
if %input% == A goto A
if %input% == B goto B
if %input% == C goto C
if %input% == D goto D

:A
mkdir A
copy C:\Windows\*.log A > log.txt
mkdir backup
copy A backup
rmdir A /s /q
goto start

:B
dir C:\Windows > log.txt
type log.txt
del log.txt
goto start

:C
set /p skaitlis1="Ievadi pirmo skaitli: "
set /p skaitlis2="Ievadi otro skaitli: "
echo Pirmais skaitlis: %skaitlis1%
echo Pirmais skaitlis: %skaitlis2%
set /a sum = %skaitlis1%+%skaitlis2%
set /a sub = skaitlis1-skaitlis2
set /a div = skaitlis1/skaitlis2
set /a mult = skaitlis1*skaitlis2

(
echo %skaitlis1%+%skaitlis2%=%sum%
echo %skaitlis1%-%skaitlis2%=%sub%
echo %skaitlis1%/%skaitlis2%=%div%
echo %skaitlis1%*%skaitlis2%=%mult%
) > log.txt
goto start

:D
set /p skaitlis=Ievadi skaitli: 
if %skaitlis% GTR 10 echo %skaitlis% ^> 10
if %skaitlis% EQU 10 echo %skaitlis% = 10
if %skaitlis% LSS 10 echo %skaitlis% ^< 10
goto start

