@echo off
SET publishDir=E:\PUBLISHCODE
SET projectPath=SLK.XClinic.WebHost\SLK.XClinic.WebHost.csproj

REM Xóa nội dung thư mục publishDir
IF EXIST "%publishDir%" (
    echo Cleaning %publishDir% ...
    DEL /F /Q "%publishDir%\*" >nul 2>&1
    FOR /D %%p IN ("%publishDir%\*") DO rmdir /S /Q "%%p"
) ELSE (
    echo Creating %publishDir% ...
    mkdir "%publishDir%"
)

REM Publish project
echo Publishing project...
dotnet publish "%projectPath%" -c Release -o "%publishDir%"
echo Publish completed.
pause

