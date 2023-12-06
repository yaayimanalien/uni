@echo off
:sakums
set /p vards=Ievadiet vardu: 
set /p uzvards=Ievadiet uzvardu: 
set /p skaitlis=Ievadiet trisciparu skaitli: 
if %skaitlis% GEQ 100 call rekinat
set /p q=Velaties atkartot programmas darbibu? (y/n)
if %q%==y (goto sakums)

echo Praktisko darbu izpildija %vards% %uzvards%. >>> rezultats.txt
chmod -h rezultats.txt
if exist %vards%_%uzvards%.txt (del %vards%_%uzvards%.txt)
ren rezultats.txt %vards%_%uzvards%.txt