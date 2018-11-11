Echo "ADD DDL in GAC"
pushd "%~dp0"
call "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\Tools\VsDevCmd.bat"
cd D:\InLab\internal-lab\Task1-2\Task1-2\bin\Debug
gacutil -i Task1-2.dll
timeout 1000
