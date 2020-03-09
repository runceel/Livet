@echo off
cd /d %~dp0
set PACKAGEVERSION=3.2.2.2
dotnet build ..\Livet.Code.sln -c=Release
rem Please get an API Key from nuget.org, and set the key using nuget setApiKey xxxx command
dotnet nuget push ..\LivetCask.Extensions\bin\Release\LivetExtensions.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.Core\bin\Release\LivetCask.Core.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.Messaging\bin\Release\LivetCask.Messaging.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.EventListeners\bin\Release\LivetCask.EventListeners.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.Converters\bin\Release\LivetCask.Converters.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.Behaviors\bin\Release\LivetCask.Behaviors.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.Mvvm\bin\Release\LivetCask.Mvvm.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.StatefulModel\bin\Release\LivetCask.StatefulModel.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask.Collections\bin\Release\LivetCask.Collections.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask\bin\Release\LivetCask.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package
dotnet nuget push ..\LivetCask2\bin\Release\LivetCask2.%PACKAGEVERSION%.nupkg -s https://www.nuget.org/api/v2/package

mkdir dist
mkdir dist\%PACKAGEVERSION%
copy ..\LivetCask.Extensions\bin\Release\LivetExtensions.%PACKAGEVERSION%.nupkg .\dist\%PACKAGEVERSION%
copy ..\LivetCask.Core\bin\Release\LivetCask.Core.%PACKAGEVERSION%.nupkg .\dist\%PACKAGEVERSION%
copy ..\LivetCask.Messaging\bin\Release\LivetCask.Messaging.%PACKAGEVERSION%.nupkg .\dist\%PACKAGEVERSION%
copy ..\LivetCask.EventListeners\bin\Release\LivetCask.EventListeners.%PACKAGEVERSION%.nupkg .\dist\%PACKAGEVERSION%
copy ..\LivetCask.Converters\bin\Release\LivetCask.Converters.%PACKAGEVERSION%.nupkg .\dist\%PACKAGEVERSION%
copy ..\LivetCask.Behaviors\bin\Release\LivetCask.Behaviors.%PACKAGEVERSION%.nupkg .\dist\%PACKAGEVERSION%
copy ..\LivetCask.Mvvm\bin\Release\LivetCask.Mvvm.%PACKAGEVERSION%.nupkg .\dist\%PACKAGEVERSION%
copy ..\LivetCask.Collections\bin\Release\LivetCask.Collections.%PACKAGEVERSION%.nupkg .\dist\%PACKAGEVERSION%
copy ..\LivetCask.StatefulModel\bin\Release\LivetCask.StatefulModel.%PACKAGEVERSION%.nupkg .\dist\%PACKAGEVERSION%
copy ..\LivetCask\bin\Release\LivetCask.%PACKAGEVERSION%.nupkg .\dist\%PACKAGEVERSION%
copy ..\LivetCask2\bin\Release\LivetCask2.%PACKAGEVERSION%.nupkg .\dist\%PACKAGEVERSION%
 