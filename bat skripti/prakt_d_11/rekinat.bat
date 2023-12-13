@echo off

set skaitlis=%1

set /a skaitlis1 = %skaitlis:~0,1%
set /a skaitlis2 = %skaitlis:~1,1%
set /a skaitlis3 = %skaitlis:~2,1%
set /a sum = %skaitlis1%+%skaitlis2%+%skaitlis3%
set /a mult = %skaitlis1%*%skaitlis2%*%skaitlis3%

if exist rezultats.txt (attrib -h rezultats.txt)

(
    echo %skaitlis1%
    echo %skaitlis2%
    echo %skaitlis3%
    echo Ciparu summa=%sum%
    echo Ciparu reizinajums=%mult%
    help attrib
) > rezultats.txt

type rezultats.txt
attrib +h rezultats.txt
