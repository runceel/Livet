@echo off
cd /d %~dp0
set PACKAGEVERSION=3.1.0
dotnet build ..\Livet.Code.sln -c=Release
rem API Key ‚Í nuget.org ‚©‚çŽæ“¾‚µ‚Ä nuget setApiKey xxxx ‚ÅƒZƒbƒg‚µ‚Ä‚­‚¾‚³‚¢
dotnet nuget push ..\LivetCask.Extensions\bin\Release\LivetExtensions.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.Core\bin\Release\LivetCask.Core.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.Messaging\bin\Release\LivetCask.Messaging.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.EventListeners\bin\Release\LivetCask.EventListeners.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.Converters\bin\Release\LivetCask.Converters.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.Behaviors\bin\Release\LivetCask.Behaviors.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask\bin\Release\LivetCask.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package

mkdir dist
copy ..\LivetCask.Extensions\bin\Release\LivetExtensions.%PACKAGEVERSION%.nupkg .\dist
copy ..\LivetCask.Core\bin\Release\LivetCask.Core.%PACKAGEVERSION%.nupkg .\dist
copy ..\LivetCask.Messaging\bin\Release\LivetCask.Messaging.%PACKAGEVERSION%.nupkg .\dist
copy ..\LivetCask.EventListeners\bin\Release\LivetCask.EventListeners.%PACKAGEVERSION%.nupkg .\dist
copy ..\LivetCask.Converters\bin\Release\LivetCask.Converters.%PACKAGEVERSION%.nupkg .\dist
copy ..\LivetCask.Behaviors\bin\Release\LivetCask.Behaviors.%PACKAGEVERSION%.nupkg .\dist
copy ..\LivetCask\bin\Release\LivetCask.%PACKAGEVERSION%.nupkg .\dist
 