@ECHO OFF
CLS
REM 删除本地硬盘*.TMP文件
REM del *.tmp /s 
for %%i in (d,e,f,g) do del %%i:\*.tmp 
EXIT
