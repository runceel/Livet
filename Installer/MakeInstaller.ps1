# ---------------------
#  Livet Installer Maker
# ---------------------
#
# 2012/09/27 Masanori Onoue (ugaya40@hotmail.com)
#
# Wix3.5以上のリンカ(light.exe)のバグによりインストーラ作成ができなくなるため、
# 必ずLivetソリューションのフォルダ自体を日本語パスの入らない場所において実行してください。
# 
# このスクリプトが正常に成功すると、
# /LivetSetup.Bootstrapper/LivetSetup.cab
# が更新されます。

$WixBinFolder = "C:\Program Files (x86)\WiX Toolset v3.6\bin"

function CopyBinaries([string] $frameworkVersion=""){

	# Copy Binaries
	Copy-Item "../.NET$frameworkVersion\Livet(.NET$frameworkVersion)\bin\Release\Livet.dll" "./Files\Binaries\NET$frameworkVersion" -Force;
	Copy-Item "../.NET$frameworkVersion\Livet(.NET$frameworkVersion)\bin\Release\Livet.xml" "./Files\Binaries\NET$frameworkVersion" -Force;
	Copy-Item "../.NET$frameworkVersion\Livet.Design(.NET$frameworkVersion)\bin\Release\Livet.Design.dll" "./Files\Binaries\NET$frameworkVersion" -Force;
	Copy-Item "../.NET$frameworkVersion\Livet.Extensions(.NET$frameworkVersion)\bin\Release\Livet.Extensions.dll" "./Files\Binaries\NET$frameworkVersion" -Force;
	Copy-Item "../.NET$frameworkVersion\Livet.Extensions(.NET$frameworkVersion)\bin\Release\Livet.Extensions.xml" "./Files\Binaries\NET$frameworkVersion" -Force;
    Copy-Item "../ReferenceAssemblies\.NET$frameworkVersion\Microsoft.Expression.Interactions.dll" "./Files\Binaries\NET$frameworkVersion" -Force;
	Copy-Item "../ReferenceAssemblies\.NET$frameworkVersion\System.Windows.Interactivity.dll" "./Files\Binaries\NET$frameworkVersion" -Force    

	
	# Copy CSharp Template Binaries
	Copy-Item "../.NET$frameworkVersion\Livet(.NET$frameworkVersion)\bin\Release\Livet.dll" "./Files\Templates\Livet_WPF$frameworkVersion`_CSharp\InfrastructureAssemblies" -Force;
	Copy-Item "../.NET$frameworkVersion\Livet(.NET$frameworkVersion)\bin\Release\Livet.xml" "./Files\Templates\Livet_WPF$frameworkVersion`_CSharp\InfrastructureAssemblies" -Force;
	Copy-Item "../.NET$frameworkVersion\Livet.Design(.NET$frameworkVersion)\bin\Release\Livet.Design.dll" "./Files\Templates\Livet_WPF$frameworkVersion`_CSharp\InfrastructureAssemblies\Design" -Force;
	Copy-Item "../ReferenceAssemblies\.NET$frameworkVersion\Microsoft.Expression.Interactions.dll" "./Files\Templates\Livet_WPF$frameworkVersion`_CSharp\InfrastructureAssemblies" -Force;
	Copy-Item "../ReferenceAssemblies\.NET$frameworkVersion\System.Windows.Interactivity.dll" "./Files\Templates\Livet_WPF$frameworkVersion`_CSharp\InfrastructureAssemblies" -Force;
	
	# Copy VisualBasic Template Binaries
	Copy-Item "../.NET$frameworkVersion\Livet(.NET$frameworkVersion)\bin\Release\Livet.dll" "./Files\Templates\Livet_WPF$frameworkVersion`_VB\InfrastructureAssemblies" -Force;
	Copy-Item "../.NET$frameworkVersion\Livet(.NET$frameworkVersion)\bin\Release\Livet.xml" "./Files\Templates\Livet_WPF$frameworkVersion`_VB\InfrastructureAssemblies" -Force;
	Copy-Item "../.NET$frameworkVersion\Livet.Design(.NET$frameworkVersion)\bin\Release\Livet.Design.dll" "./Files\Templates\Livet_WPF$frameworkVersion`_VB\InfrastructureAssemblies\Design" -Force;
	Copy-Item "../ReferenceAssemblies\.NET$frameworkVersion\Microsoft.Expression.Interactions.dll" "./Files\Templates\Livet_WPF$frameworkVersion`_VB\InfrastructureAssemblies" -Force;
	Copy-Item "../ReferenceAssemblies\.NET$frameworkVersion\System.Windows.Interactivity.dll" "./Files\Templates\Livet_WPF$frameworkVersion`_VB\InfrastructureAssemblies" -Force;
}

function Cleanup(){

    if(Test-Path ".\disk1"){
    Remove-Item ".\disk1" -Force -Recurse
    }
    if(Test-Path ".\out"){
    Remove-Item ".\out" -Force -Recurse
    }

    Get-ChildItem -Path "./Files\Templates\*" -Include *.zip | Remove-Item
}

function ProcessErrorHandling([string] $processName=""){
    $errorCode = $LASTEXITCODE
    if($errorCode -gt 0){
        throw "●Error $processName -- ExitCode :" + $errorCode
    }
}

trap {
    echo "●Error";
    echo $Error
    $host.UI.ReadLine()
    break ;
}

$ErrorActionPreference = "Stop"

Cleanup

# Copy Binaries

echo "●Start --- CopyBinaries"
CopyBinaries "4.0"
CopyBinaries "4.5"

Copy-Item "../ReferenceAssemblies\Microsoft.WindowsAPICodePack.dll" "./Files\Binaries" -Force;
Copy-Item "../ReferenceAssemblies\Microsoft.WindowsAPICodePack.Shell.dll" "./Files\Binaries" -Force
Copy-Item "../Livet.ItemTemplateExtension\bin\Release\Livet.ItemTemplateExtension.dll" "./Files" -Force
echo "●End --- CopyBinaries"


# Compress Templates

echo "●Start --- Compress Templates"
$folders = Get-ChildItem "./Files\Templates" -Exclude "*.zip"
foreach($templateFolder in $folders){
	$fullName = $templateFolder.FullName
	$name = $templateFolder.Name
	$ParentfolderPath = $templateFolder.Parent.FullName
	$zipPath = $ParentfolderPath +"\"+ $name + ".zip"
	Start-Process -NoNewWindow -Wait -FilePath "./LivetZipConsole.exe" -ArgumentList "-c `"$fullName`" `"$zipPath`""
    ProcessErrorHandling "LivetZipConsole.exe"
}
echo "●End --- Compress Templates"

# Make msi & cab

echo "●Start --- Make msi"
Start-Process -NoNewWindow -Wait -FilePath "$WixBinFolder\candle.exe" -ArgumentList "Product.wxs -ext `"$WixBinFolder\WixUtilExtension.dll`" -ext `"$WixBinFolder\WixVSExtension.dll`" -ext `"$WixBinFolder\WixUIExtension.dll`" -out `"out\Product.wixobj`""
ProcessErrorHandling "candle.exe"
Start-Process -NoNewWindow -Wait -FilePath "$WixBinFolder\light.exe" -ArgumentList "`"out\Product.wixobj`" -cultures:en-US -sice:ICE30  -ext `"$WixBinFolder\WixUtilExtension.dll`" -ext `"$WixBinFolder\WixVSExtension.dll`" -ext `"$WixBinFolder\WixUIExtension.dll`" -loc English.wxl -out `"out\LivetSetup_en_US.msi`""
ProcessErrorHandling "light(en-US).exe"
Start-Process -NoNewWindow -Wait -FilePath "$WixBinFolder\light.exe" -ArgumentList "`"out\Product.wixobj`" -cultures:ja-JP -sice:ICE30  -ext `"$WixBinFolder\WixUtilExtension.dll`" -ext `"$WixBinFolder\WixVSExtension.dll`" -ext `"$WixBinFolder\WixUIExtension.dll`" -loc Japanese.wxl -out `"out\LivetSetup_ja_JP.msi`""
ProcessErrorHandling "light(ja-JP).exe"
Start-Process -NoNewWindow -Wait -FilePath "$WixBinFolder\torch.exe" -ArgumentList "-p -t language `"out\LivetSetup_en_US.msi`" `"out\LivetSetup_ja_JP.msi`" -out `"out\ja-JP.mst`""
ProcessErrorHandling "torch.exe"
echo "●End --- Make msi"

echo "●Start --- Make cab"
$cabList = Get-ChildItem "./out" | foreach{"`"" + $_.FullName + "`""}
Out-File -Encoding Default "./out\LivetSetup.lst" -InputObject $cabList
Start-Process -NoNewWindow -Wait -FilePath "makecab" -ArgumentList "/D MaxDiskSize=102400000 /F `"out/LivetSetup.lst`""
ProcessErrorHandling "makecab.exe"
echo "●End --- Make cab"

Copy-Item ".\disk1\1.cab" "../LivetSetup.Bootstrapper/LivetSetup.cab" -Force

Cleanup

echo "●Completed"

$host.UI.ReadLine() 
