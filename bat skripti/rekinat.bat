@echo off
setlocal enabledelayedexpansion

if %parametrs% == + set /a rez=%skaitlis1%+%skaitlis2%
if %parametrs% == - set /a rez=%skaitlis1%-%skaitlis2%
if %parametrs% == * set /a rez=%skaitlis1%*%skaitlis2%
if %parametrs% == / set /a rez=%skaitlis1%/%skaitlis2%
if %parametrs% == 2 goto kapinsana
:h
(
echo Rezultats:
echo %skaitlis1%%parametrs%%skaitlis2%=%rez%
) > log.txt

type log.txt

echo Aprekinatais rezultats ir: %rez%

if %rez% GEQ 10 goto divcipari
goto viencipari
:divcipari
set firstCharacter=!rez:~0,1!
set secondCharacter=!rez:~1,1!
echo 1. cipars %firstCharacter%
echo 2. cipars %secondCharacter%
goto beigas
:viencipari
echo nav divciparu skaitlis
goto beigas
:kapinsana
set /a rez=%skaitlis1%*%skaitlis1%
set %parametrs%=^^
set %skaitlis2%=2
goto h
:beigas
REM Reinis Jānis Barons DvDz 3
