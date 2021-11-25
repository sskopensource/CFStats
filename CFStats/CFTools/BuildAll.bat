@echo off
Echo BuildAll.bat
Echo Building CFStats solution

IF "%1"=="--debug" (goto debug)
IF "%1"=="--release" (goto release)
IF "%1"=="--clean" (
ECHO Cleaning Output\Bin\
IF "%2"=="--debug" (
call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe C:\MyProjects\CFStats\CFStats\CFStats.sln /property:Configuration=Debug /target:Clean
IF "%3"=="--nobuild" (
  goto end
)
goto debug
)
IF "%2"=="--release" (
call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe C:\MyProjects\CFStats\CFStats\CFStats.sln /property:Configuration=Release /target:Clean
IF "%3"=="--nobuild" (
  goto end
)
goto release
)
IF "%2"=="--nobuild" (
call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe C:\MyProjects\CFStats\CFStats\CFStats.sln /property:Configuration=Debug /target:Clean
call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe C:\MyProjects\CFStats\CFStats\CFStats.sln /property:Configuration=Release /target:Clean
  goto end
)
call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe C:\MyProjects\CFStats\CFStats\CFStats.sln /property:Configuration=Debug /target:Clean
call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe C:\MyProjects\CFStats\CFStats\CFStats.sln /property:Configuration=Release /target:Clean
goto all
)
goto all

:debug
ECHO Build debug to Output\Bin\Debug...
call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe C:\MyProjects\CFStats\CFStats\CFStats.sln /property:Configuration=Debug
goto end

:release
ECHO Build debug to Output\Bin\Release...
call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe C:\MyProjects\CFStats\CFStats\CFStats.sln /property:Configuration=Release
goto end

:all
ECHO Build debug to Output\Bin\Debug...
ECHO Build debug to Output\Bin\Release...
call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe C:\MyProjects\CFStats\CFStats\CFStats.sln /property:Configuration=Debug
call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe C:\MyProjects\CFStats\CFStats\CFStats.sln /property:Configuration=Release

:end
Echo Build is Completed