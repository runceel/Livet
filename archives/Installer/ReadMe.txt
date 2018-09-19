このフォルダ内にあるMakeInstaller.ps1スクリプトを実行すると
/LivetSetup.Bootstrapper/LivetSetup.cabが更新されます。
その後LivetSetup.Bootstrapperプロジェクトをビルドすることでインストーラーが作成されます。

★★★MakeInstaller.ps1スクリプト実行上の注意★★★
Wix3.6以上必須です。
MakeInstaller.ps1内の$WixBinFolder変数を適せん[Wixインストーラフォルダ]\binフォルダのパスに書き換えてください。
Wix3.5以上のリンカ(light.exe)のバグによりインストーラ作成ができなくなるため、
必ずLivetソリューションのフォルダ自体を日本語パスの入らない場所において実行してください。