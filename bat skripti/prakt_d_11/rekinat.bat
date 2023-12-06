@echo on


set skaitlis1 = %skaitlis:~0,1%
set skaitlis2 = %skaitlis:~1,1%
set skaitlis3 = %skaitlis:~2,1%
set /a sum = %skaitlis1%+%skaitlis2%+%skaitlis3%
set /a mult = %skaitlis1%*%skaitlis2%*%skaitlis3%

(
echo Ciparu summa=%sum%
echo Ciparu reizinajums=%mult%
help attrib
) > rezultats.txt

type rezultats.txt