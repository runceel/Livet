@echo off
cd /d %~dp0
set PACKAGEVERSION=3.2.2.2
dotnet build ..\Livet.Code.sln -c=Release

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
