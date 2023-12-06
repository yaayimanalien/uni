@echo off
:sakums
set /p skaitlis1=Ievadiet 1mo skaitli: 
set /p skaitlis2=Ievadiet 2tro skaitli: 

REM cls

echo + prieks saskaitisanas
echo - prieks atnemsanas
echo * prieks reizinasanas
echo / prieks dalisanas
echo 2 prieks pakape 2
:ievade
set /p parametrs=Ievadiet parametru: 


if %parametrs% == + goto rekinat
if %parametrs% == - goto rekinat
if %parametrs% == * goto rekinat
if %parametrs% == / goto rekinat
if %parametrs% == 2 goto rekinat
goto :ievade

:rekinat
call rekinat

echo programma patrauc darbu!!!
set /p atkartot=vai atkartot (y/n)?
if %atkartot%==y goto sakums
if %atkartot%==n echo Bye!!
timeout 2
REM Reinis Jānis Barons DvDz 3