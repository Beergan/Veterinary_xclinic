@ECHO OFF
SETLOCAL

IF "%~1"=="" (
    FOR /F %%i IN ('powershell -NoProfile -Command "Get-Date -Format yyyyMMddHHmmss"') DO SET "name=%%i"
) ELSE (
    SET "name=%~1"
)

dotnet ef migrations add "%name%" --context DbMssqlContext --project ./SLK.XClinic.Db -s ./SLK.XClinic.WebHost --output-dir Migrations
dotnet ef database update --context DbMssqlContext --project ./SLK.XClinic.Db -s ./SLK.XClinic.WebHost

PAUSE
