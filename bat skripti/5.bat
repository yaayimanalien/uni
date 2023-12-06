@echo off

set /p skaitlis=ievadiet skaitli: 
set /a reizinajums=%skaitlis%*3

echo %reizinajums%

pause

echo %skaitlis%*3=%reizinajums% > rez.txt