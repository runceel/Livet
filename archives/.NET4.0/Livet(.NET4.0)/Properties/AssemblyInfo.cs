using System.Reflection;
using System.Runtime.InteropServices;

using System.Windows.Markup;
using System; 

// アセンブリに関する一般情報は以下の属性セットをとおして制御されます。
// アセンブリに関連付けられている情報を変更するには、
// これらの属性値を変更してください。

[assembly: AssemblyTitle("Livet")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Livet Project")]
[assembly: AssemblyProduct("Livet")]
[assembly: AssemblyCopyright("Copyright © 2010 - 2013 Livet Project All Rights Reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: CLSCompliant(true)]

// ComVisible を false に設定すると、その型はこのアセンブリ内で COM コンポーネントから 
// 参照不可能になります。COM からこのアセンブリ内の型にアクセスする場合は、
// その型の ComVisible 属性を true に設定してください。

[assembly: ComVisible(false)]

// 次の GUID は、このプロジェクトが COM に公開される場合の、typelib の ID です

[assembly: Guid("4a4b29c1-d9f4-4468-a10f-a1dae74be5a9")]

// アセンブリのバージョン情報は、以下の 4 つの値で構成されています:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// すべての値を指定するか、下のように '*' を使ってビルドおよびリビジョン番号を 
// 既定値にすることができます:
// [assembly: AssemblyVersion("1.0.*")]

[assembly: AssemblyVersion("1.3.0.0")]

[assembly: XmlnsDefinition("http://schemas.livet-mvvm.net/2011/wpf", "Livet")]
[assembly: XmlnsDefinition("http://schemas.livet-mvvm.net/2011/wpf", "Livet.Commands")]
[assembly: XmlnsDefinition("http://schemas.livet-mvvm.net/2011/wpf", "Livet.Converters")]
[assembly: XmlnsDefinition("http://schemas.livet-mvvm.net/2011/wpf", "Livet.Messaging")]
[assembly: XmlnsDefinition("http://schemas.livet-mvvm.net/2011/wpf", "Livet.Behaviors")]
[assembly: XmlnsDefinition("http://schemas.livet-mvvm.net/2011/wpf", "Livet.Messaging.IO")]
[assembly: XmlnsDefinition("http://schemas.livet-mvvm.net/2011/wpf", "Livet.Messaging.Windows")]
[assembly: XmlnsDefinition("http://schemas.livet-mvvm.net/2011/wpf", "Livet.Behaviors.Messaging")]
[assembly: XmlnsDefinition("http://schemas.livet-mvvm.net/2011/wpf", "Livet.Behaviors.Messaging.IO")]
[assembly: XmlnsDefinition("http://schemas.livet-mvvm.net/2011/wpf", "Livet.Behaviors.Messaging.Windows")]
[assembly: XmlnsDefinition("http://schemas.livet-mvvm.net/2011/wpf", "Livet.Behaviors.ControlBinding")]
[assembly: XmlnsDefinition("http://schemas.livet-mvvm.net/2011/wpf", "Livet.Behaviors.ControlBinding.OneWay")]

#if NET4
[assembly: AssemblyFileVersion("1.3.0.4")]
#elif NET45
[assembly: AssemblyFileVersion("1.3.0.45")]
#endif