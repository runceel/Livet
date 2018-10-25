using System.Reflection;
using System.Runtime.InteropServices;

using System.Windows.Markup;
using System;
using System.Runtime.CompilerServices;

// アセンブリに関する一般情報は以下の属性セットをとおして制御されます。
// アセンブリに関連付けられている情報を変更するには、
// これらの属性値を変更してください。

[assembly: AssemblyTitle( "Livet.Extensions" )]
[assembly: AssemblyDescription( "Extension libraries Livet" )]
[assembly: AssemblyConfiguration( "" )]
[assembly: AssemblyCompany( "Livet Project" )]
[assembly: AssemblyProduct( "Livet" )]
[assembly: AssemblyCopyright( "Copyright © 2010 - 2012 Livet Project All Rights Reserved." )]
[assembly: AssemblyTrademark( "" )]
[assembly: AssemblyCulture( "" )]

[assembly: CLSCompliant( true )]

[assembly: ComVisible( false )]
[assembly: AssemblyVersion("1.0.3.0")]

#if DEBUG
[assembly: InternalsVisibleTo( "Livet.Extensions.Test, PublicKey=0024000004800000940000000602000000240000525341310004000001000100216ecd468f460823d07574d100f73d64e29432bc4da1d1d06cee5463065c13ec3625bdf84872666ec0a2d1c6d1c139785cf53a09a76e9310d8cb3956625380ae2fe8f0c5febffb27eaf5e98ef43d6bf97e17582b443662a41495e00d4fbc50b39d8878692c6ff9075f8ac1d9aa6a7cf303f92474948a10b588e7dddb252cd0b4" )]
[assembly: InternalsVisibleTo( "Livet.Extensions.TestApplication, PublicKey=0024000004800000940000000602000000240000525341310004000001000100216ecd468f460823d07574d100f73d64e29432bc4da1d1d06cee5463065c13ec3625bdf84872666ec0a2d1c6d1c139785cf53a09a76e9310d8cb3956625380ae2fe8f0c5febffb27eaf5e98ef43d6bf97e17582b443662a41495e00d4fbc50b39d8878692c6ff9075f8ac1d9aa6a7cf303f92474948a10b588e7dddb252cd0b4" )]
#endif

[assembly: XmlnsDefinition( "http://schemas.livet-mvvm.net/2011/wpf", "Livet.Messaging.IO" )]
[assembly: XmlnsDefinition( "http://schemas.livet-mvvm.net/2011/wpf", "Livet.Behaviors.Messaging.IO" )]

#if NET4
[assembly: AssemblyFileVersion("1.0.3.4")]
#elif NET45
[assembly: AssemblyFileVersion("1.0.3.45")]
#endif
