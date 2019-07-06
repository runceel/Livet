using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Markup;

// アセンブリに関する一般情報は以下の属性セットをとおして制御されます。
// アセンブリに関連付けられている情報を変更するには、
// これらの属性値を変更してください。
[assembly: AssemblyTitle("Livet")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Livet Project")]
[assembly: AssemblyProduct("Livet")]
[assembly: AssemblyCopyright("Copyright © 2010 - 2018 Livet Project All Rights Reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// ComVisible を false に設定すると、このアセンブリ内の型は COM コンポーネントから
// 参照できなくなります。COM からこのアセンブリ内の型にアクセスする必要がある場合は、
// その型の ComVisible 属性を true に設定してください。
[assembly: ComVisible(false)]

// このプロジェクトが COM に公開される場合、次の GUID が typelib の ID になります
[assembly: Guid("1e476a17-6c4d-4ad2-95b2-84bef4c96d67")]

// アセンブリのバージョン情報は次の 4 つの値で構成されています:
//
//      メジャー バージョン
//      マイナー バージョン
//      ビルド番号
//      Revision
//
// すべての値を指定するか、次を使用してビルド番号とリビジョン番号を既定に設定できます
// 以下のように '*' を使用します:
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

[assembly: AssemblyFileVersion("1.3.0.0")]
