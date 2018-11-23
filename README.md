# Livet, a MVVM Infrastructure for WPF
---

## はじめかた

以下の Visual Studio 拡張機能を導入するとプロジェクトテンプレートやアイテムテンプレートやコードスニペットが追加されます。

[Livet プロジェクトテンプレート・アイテムテンプレート・コードスニペット拡張機能](https://marketplace.visualstudio.com/items?itemName=okazuki.livet)

NuGet での導入も可能ですが、この場合はテンプレートやスニペットは導入されません。状況に合わせて使い分けてください。

- [LivetCask](https://www.nuget.org/packages/LivetCask/)
- [LivetExtensions](https://www.nuget.org/packages/LivetExtensions/)

## 使用方法

基本的な使用方法は下記ブログ記事を参照してください。

[Livet Project Home (Japanese)](http://ugaya40.hateblo.jp/entry/Livet)

追加として `lsprop` コードスニペットで下記のような短いプロパティの定義が生成されます。

```cs
private string _name;
public string Name
{
	get => _name;
	set => RaisePropertyChangedIfSet(ref _name, value);
}
```

RaisePropertyChangedIfSet メソッドは、第一引数に第二引数の値を代入して PropertyChanged イベントを発行して true を返します。
値が変わっていない場合はイベントの発行は行わず false を返します。

## 今後基本メンテナンス方針

最新の Livet はサポートが提供されている .NET Framework をターゲットとしてメンテナンスを行う予定です。

機能拡張などがあれば Pull Request を送ってください。Pull Request を送る場合は、単体テストをセットでつけてテストが通るようにしておいてください。
なるべく確認して取り込むようにしたいと思います。

GitHub の通知に気付いていない可能性もあるので、急ぎの場合は Twitter の @okazuki までメンションいただけると対応が早くなる可能性があります。

## Licensing
---
[zlib/libpng](http://opensource.org/licenses/zlib-license.php)
