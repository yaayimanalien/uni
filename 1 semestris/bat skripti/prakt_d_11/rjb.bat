@echo off
:sakums
set /a skaitlis1=0
set /a skaitlis2=0
set /a skaitlis3=0
set /a skaitlis=0

set /p vards=Ievadiet vardu: 
set /p uzvards=Ievadiet uzvardu: 
set /p skaitlis=Ievadiet trisciparu skaitli: 
if %skaitlis% GEQ 100 call rekinat %skaitlis%

set skaitlis1=
set skaitlis2=
set skaitlis3=
set skaitlis=

set /p q=Velaties atkartot programmas darbibu? (y/n)
if %q%==y (goto sakums)

echo Praktisko darbu izpildija %vards% %uzvards%. >> rezultats.txt
attrib -h rezultats.txt
if exist %vards%_%uzvards%.txt (del %vards%_%uzvards%.txt)
ren rezultats.txt %vards%_%uzvards%.txt