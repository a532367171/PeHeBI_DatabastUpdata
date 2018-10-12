@echo off

ver | Find "5.0">nul 
if %ERRORLEVEL%==0 goto Win2000
ver | Find "5.1">nul 
if %ERRORLEVEL%==0 goto WinXP
ver | Find "6.3">nul 
if %ERRORLEVEL%==0 GOTO Win8
ver | Find "6.1">nul 
if %ERRORLEVEL%==0 GOTO Win8
Exit

:WinXP 
 echo "Microsoft Windows XP [°æ±¾ 5.1.2600]"
 Goto RegFile

:Win2000
 REM echo "Win2000"
 Goto RegFile

:Win8
 ECHO "Microsoft Windows [°æ±¾ 6.3.9600]"
 SystemInfo | Find "X86">nul 
 if %ERRORLEVEL%==0 goto RegFile 

 systeminfo | Find "x64">nul 
 if %ERRORLEVEL%==0 goto Win8-64 

:RegFile
 Copy *.* %windir%\system32\.
 regsvr32.exe %windir%\system32\PageShow.dll
 regsvr32.exe %windir%\system32\SetPrn.dll
 regsvr32.exe %windir%\system32\baoJing.ocx
 regsvr32.exe %windir%\system32\MSCOMCTL.OCX
 goto Win9
:Win8-64 
 Copy *.* %windir%\SysWOW64\.
 regsvr32.exe %windir%\SysWOW64\PageShow.dll
 regsvr32.exe %windir%\SysWOW64\SetPrn.dll
 regsvr32.exe %windir%\SysWOW64\baoJing.ocx
 goto Win9
:Win9