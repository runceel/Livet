[日本語はこちら](README.md)

Work in progress...

# Livet

## About Livet

Livet is an infrastructure for MVVM(Model/View/ViewModel) pattern on WPF.
It is supporting .NET Framework 4.5.2 or lator and .NET Core 3.0(still in preview), and it is provided zlib/libpng license.
At zlib/libpng licence, you don't need displaying copyright using just a library, when you publish a software with the library.

At zlib/libpng licence, you don't need displaying copyright, when you publish a software with the library.
However, if you changed the source code, you would have to need it.

## Introduction

Livet can be used using an extension of Visual Studio 2017 / 2019. It provides a project template, item tempaltes and useful code snippets. It is designed the best when using it.
The extension can be found searching Livet at online category on `Manage extensions`.

![](images/2019-07-01-16-19-40.png)

And the library is published on NuGet.

- [LivetCask](https://www.nuget.org/packages/LivetCask/)
- [LivetExtensions](https://www.nuget.org/packages/LivetExtensions/)

## Working with Visual Studio and Livet

Livet is designed to use on Visual Studio.

#### Visual Studio features for Livet

Livet provides Project templates, Item templates and code snippets.

![Project templates](images/2019-07-01-16-24-39.png)

![Item templates](images/2019-07-01-16-25-38.png)

Code snippets are as below:

- lvcom : ViewModelCommand
- lvcomn : ViewModelCommand(Non CanExecute)
- llcom : ListenerCommand(with a parameter)
- llcomn : ListenerCommand(with a parameter, Non CanExecute)
- lprop : Notification property
- lsprop : Notification property(Short version)

## View support features

Livet provides features to be able to use data binding any place at View layer.

#### Behaviors that make non bindable property to be bindable property.

WPF provides data binding feature for dependency properties, however, there aren't non bindable properties.
So, we want to use data binding, but we are writing code to sync data at code behind.

Livet provides behaviors and actions to make non bindable properties to be able to bind ( excludes start with type of 'System.Windows').

```xml
<Button Height="50" Content="Please mouse over here">
    <i:Interaction.Triggers>
        <i:EventTrigger EventName="MouseEnter">
            <!-- Originally, IsMouseOver is not a bindable property -->
            <l:ButtonSetStateToSourceAction Source="{Binding ButtonMouseOver, Mode=TwoWay}" Property="IsMouseOver" />
        </i:EventTrigger>
        <i:EventTrigger EventName="MouseLeave">
            <!--  Originally, IsMouseOver is a not bindable property  -->
            <l:ButtonSetStateToSourceAction Source="{Binding ButtonMouseOver, Mode=TwoWay}" Property="IsMouseOver" />
        </i:EventTrigger>
    </i:Interaction.Triggers>
</Button>
```

```xml
<WebBrowser Grid.Row="1" Grid.ColumnSpan="2">
    <i:Interaction.Behaviors>
        <!--  Originally, Source is not a bindable property  -->
        <l:WebBrowserSetStateToControlBehavior Source="{Binding Url}" Property="Source" />
    </i:Interaction.Behaviors>
</WebBrowser>
```

And, Livet provides a behavior make non bindable properties SelectedText, SelectionLength and SelectionStart to be able to bind for TextBox.

```xml
<TextBox>
    <i:Interaction.Behaviors>
        <l:TextBoxBindingSupportBehavior
            SelectedText="{Binding SelectedText}"
            SelectionLength="{Binding SelectionLength}"
            SelectionStart="{Binding SelectionStart}" />
    </i:Interaction.Behaviors>
</TextBox>
```

Same as TextBox, Livet provides a behavior make non bindable Password property to be able to bind for PasswordBox.

```xml
<PasswordBox>
    <i:Interaction.Behaviors>
        <l:PasswordBoxBindingSupportBehavior Password="{Binding Password}" />
    </i:Interaction.Behaviors>
</PasswordBox>
```

#### Calling ViewModel's method from View's event

In Livet, LivetCallMethodAction is provided to invoke a ViewModel's method.
It is better performance than standard CallMethodAction, and it is passing a parameter using MethodParameter.

```xml
<TextBox x:Name="textBox">
    <i:Interaction.Triggers>
        <i:EventTrigger EventName="TextChanged">
            <l:LivetCallMethodAction
                MethodName="TextChanged"
                MethodParameter="{Binding Text, ElementName=textBox}"
                MethodTarget="{Binding}" />
        </i:EventTrigger>
    </i:Interaction.Triggers>
</TextBox>
```

#### Messenger

At Livet.Behaviors.Messaging namespace, there is an action for receiving a message from Messenger of Livet.
The action is not only receiving a message, it can fire an another action from EventTrigger and other triggers.

So, it can simply show an another window, display a confirm dialog and more when triggered click event, don't throuth ViewModel layer.
So, it can show an another window, display a confirm dialog and more when triggered click event, without go through ViewModel layer, simply.

```
Reference information:
At almost all libraries for MVVM pattern, when a button clicked and then displaying a confirm dialog, and process the result at ViewModel layer, it has to receive event using command at ViewModel, and sending a message to View layer, and then process the message, and passing the result using callback to ViewModel layer.

Flow of usual MVVM libraries: View -> ViewModel -> View -> ViewModel
Flow of Livet: View -> ViewModel
```

And also, you can pass a return value to a ViewModel's method and command, when the message has a return value(for ex: message for showing confirmation dialog).

A case of sending a message from ViewModel, first define InteractionMessageTrigger at View layer and set action to the message.

```xml
<l:InteractionMessageTrigger MessageKey="MessageKey_Confirm" Messenger="{Binding Messenger}">
    <l:ConfirmationDialogInteractionMessageAction />
</l:InteractionMessageTrigger>
```

And, sending a message using Messenger from ViewModel.

```cs
public async void ConfirmFromViewModel()
{
    var message = new ConfirmationMessage("This is a test message.", "For test", "MessageKey_Confirm")
    {
        Button = MessageBoxButton.OKCancel,
    };
    await Messenger.RaiseAsync(message);
    OutputMessage = $"{DateTime.Now}: ConfirmFromViewModel: {message.Response ?? false}";
}
```

Using `MessageKey_Confirm` as a message key, which deciding InteractionMessageTrigger is invoked.

For view origin, defining DirectInteractionMessage to Action, and defining a message you use to a child of DirectInteractionMessage.

```xml
<Button Content="ConfirmFromView">
    <i:Interaction.Triggers>
        <i:EventTrigger EventName="Click">
            <l:ConfirmationDialogInteractionMessageAction>
                <l:DirectInteractionMessage CallbackMethodName="ConfirmFromView" CallbackMethodTarget="{Binding}">
                    <l:ConfirmationMessage Caption="For test" Text="This is a test message." />
                </l:DirectInteractionMessage>
            </l:ConfirmationDialogInteractionMessageAction>
        </i:EventTrigger>
    </i:Interaction.Triggers>
</Button>
```

In the above example, after executing Action, setting to call ConfirmFromView method of ViewModel.
At ConfirmFromView method, its can use the message.

```cs
public void ConfirmFromView(ConfirmationMessage message)
{
    OutputMessage = $"{DateTime.Now}: ConfirmFromView: {message.Response ?? false}";
}
```

Actions and Messages are defined in Livet are confirmation dialog, information diealog, file dialog, navigating window, folder dialog(It references Windows API Code Pack, so, it is deferent package that is Livet.Extensions) and more.

A following code is an example to use folder selection dialog message of Livet.Extensions.

```xml
<Button Content="Folder">
    <i:Interaction.Triggers>
        <i:EventTrigger EventName="Click">
            <l:FolderBrowserDialogInteractionMessageAction>
                <l:DirectInteractionMessage CallbackMethodName="FolderSelected" CallbackMethodTarget="{Binding}">
                    <l:FolderSelectionMessage Description="Select folder" DialogPreference="None" />
                </l:DirectInteractionMessage>
            </l:FolderBrowserDialogInteractionMessageAction>
        </i:EventTrigger>
    </i:Interaction.Triggers>
</Button>
```

#### General purpose EnumToBooleanConverter

In Livet, there are classes that implements IValueConverter to convert between boolean and enum that are all enum type under System.Windows namespace.

```xml
<Window.WindowState>
    <Binding ElementName="checkBox" Path="IsChecked">
        <Binding.Converter>
            <l:WindowStateAndBooleanConverter
                ConvertBackDefaultBooleanValue="False"
                ConvertBackWhenNormal="True"
                ConvertWhenFalse="Maximized"
                ConvertWhenTrue="Normal" />
        </Binding.Converter>
    </Binding>
</Window.WindowState>
```

#### Other view features

DataTrigger of Blend SDK don't support initial value. So, LivetDataTrigger that can set initial value, and also, there are SetFocusAction to manage focus, WindowCloseCancelBehavior that cancel Window close and delegate canceling logic to ViewModel, DataContextDisposeAction that is to call Dispose method of DataContext when Window closing, and more.

## ViewModel support

Livet は Presentation Domain Separation(PDS) に沿って開発されることを前提としています。その前提の上では ViewModel にはあまりコードが書かれないという考えの上で ViewModel サポートの機能を提供しています。

#### ViewModel の Messenger プロパティと CompositeDisposable プロパティ

Messenger は前述の View サポートの Messenger で解説したメッセージを受け取るアクションに ViewModel からメッセージを伝えるために用意されています。CompositeDisposable プロパティは IEnumerable<IDisposable> インターフェースを実装していて、ViewModel が Dispose される際に同時に破棄したいリソースを格納するために使用されます。

Livet の ViewModel 機能を使用する場合は、ViewModel と一緒に破棄したいリソースは基本的に ViewModel の CompositeDisposable プロパティに追加する事になります。

```cs
CompositeDisposable.Add(someResource);
```

#### DispatcherCollectionとReadOnlyDispatcherCollection

DispatcherCollection は、既存の変更通知コレクションをコンストラクタの引数にとり、その変更通知を指定された Dispatcher 上で行うコレクションです。ReadOnlyDispatcherCollection、DispatcherCollection をコンストラクタの引数にとる読み取り専用ラッパーとなります。

#### ViewModelHelper.CreateReadOnlyDispatcherCollection<TModel,TViewModel>

CreateReadOnlyDispatcherCollection を使用すると、Model の変更通知コレクションを指定し、その Model のコレクションの変更と連動する ReadOnlyDispatcherCollection を生成できます。Func<TModel,TViewModel> を指定して TMode l型と TViewModel 型の相互変換を行います。

```cs
var source = new ObservableCollection<int> { 1, 2, 3 };
var result = ViewModelHelper.CreateReadOnlyDispatcherCollection(
    source,
    x => new TestViewModel(x * x),
    DispatcherHelper.UIDispatcher);
```

CreateReadOnlyDispatcherCollection を使用して生成された TViewModel の要素が IDisposable であった場合、source コレクションから Remove された場合など要素削除時には Dispose が呼ばれます。
生成されたコレクションの Dispose を呼ぶことで、ソースコレクションとの連動は解除され、TViewModel が IDisposable であった場合は生成された TViewModel 型に対して Dipose が呼ばれます。

#### PropertyChangedEventListener/CollectionChangedEventListener

ViewModel では Model のイベントを監視するケースが多くあります。C# でイベントハンドラの監視と解除をラムダ式を使って行うと解除が出来ないという問題があります。

```cs
// 購読解除できない
var model = new Model();
model.PropertyChanged += (s, e) =>
{
    // do something
};
```

Livet の PropertyChangedEventListener を使用すると、ラムダ式を使用したプロパティ変更のイベントのハンドリングが出来て購読解除を行うことも出来ます。

```cs
var model = new Model();
var listener = new PropertyChangedEventListener(model)
{
    // コレクション初期化子で指定可能
    {
        // プロパティ名指定でイベントハンドラーを設定
        nameof(Model.Input1),
        (s, e) =>
        {
            // do something
        }
    },
    {
        // プロパティ名を式木で設定
        () => model.Input2,
        (s, e) =>
        {
            // do something
        }
    },
    // プロパティ名を指定せずに PropertyChanged イベントに対する処理も設定可能
    (s, e) =>
    {
        // do something
    }
};

// 個別登録も可能
listener.RegisterHandler(nameof(Model.Input1), (s, e) => { });
listener.RegisterHandler(() => model.Input2, (s, e) => { });
listener.RegisterHandler((s, e) => { });

// 購読解除（ViewModel の破棄時に解除する場合は前述の CompositeDisposable を使用
listener.Dispose();
```

CollectionChangedEventListener はそのコレクション変更通知版です。PropertyChangedEventListener ほど多機能ではありませんが似た様な事が可能です。
また、汎用 EventListener として EventListener を用意してあります。

```cs
var model = new Model();
var handler = new EventListener<EventListener<SampleEventArgs>>(
    h => model.SampleEvent += h,
    h => model.SampleEvent -= h,
    (s, e) =>
    {
        // do something
    });

// 購読解除
handler.Dispose();
```

## Model サポート

Model は MVVM の関心領域ではないため、Livet でも特に手厚いサポートはありません。
しかし最低限の機能として、変更通知イベント基底クラスとなる NotificationObject と、スレッドセーフな変更通知コレクションである ObservableSynchronizedCollection を用意してあります。
ObservableSyncronizedCollection は Monitor ベースのスレッドセーフなコレクションではなく、ReaderWriterLockSlim によるスレッドセーフなコレクションであり、読み書きが等しく複数スレッドから煩雑に行われるシナリオにおいて、パフォーマンスと変更通知のタイミングの偏りのバランスが良い様に設計されています。
前述した ViewModel の DispatcherCollection はただのラッパーであるため、Model では通常の ObservableCollection と ObservableSyncronizedCollection を用途に応じて使い分け、それを ViewModel では同様に扱う事ができます。

NotificationObject にはプロパティの定義を簡略化するための以下のメソッドが定義されています。また、NotificationObject は ViewModel クラスにも継承されているため、ここで説明する内容は ViewModel でも使用できます。

#### RaisePropertyChanged メソッド

プロパティ名指定で PropertyChanged イベントを発行します。

```cs
private string _Name;
public string Name
{
    get => _Name;
    set
    {
        _Name = value;
        RaisePropertyChanged(); // CallerMemberName により自動でプロパティ名が設定されます
    }
}
```

明示的に指定することも出来ます。

```cs
RaisePropertyChanged(nameof(Name));
```

#### RaisePropertyChangedIfSet メソッド

フィールドの更新と PropertyChanged イベントの発行を行います。このメソッドを使うとプロパティの定義は以下のようになります。このプロパティの定義は、コードスニペットの lsprop で生成できます。

```cs
private string _Name;
public string Name
{
    get => _Name;
    set => RaisePropertyChangedIfSet(ref _Name, value);
}
```

RaisePropertyChangedIfSet メソッドでは、第三引数に関連するプロパティ名を渡すことで、そのプロパティに対しても PropertyChanged イベントを発行出来ます。

```cs
private string _FirstName;
public string FirstName
{
    get => _FirstName;
    // FirstName の他に FullName の PropertyChanged イベントも発行する
    set => RaisePropertyChangedIfSet(ref _FirstName, value, nameof(FullName));
}

private string _LastName;
public string LastName
{
    get => _LastName;
    // FirstName の他に FullName の PropertyChanged イベントも発行する
    set => RaisePropertyChangedIfSet(ref _LastName, value, nameof(FullName));
}

public string FullName => $"{FirstName} {LastName}";
```

関連するプロパティが複数ある場合は配列で渡します。

```cs
public string _Hoge;
public string Hoge
{
    get => _Hoge;
    set => RaisePropertyChangedIfSet(ref _Hoge, value, new[]
    {
        nameof(Foo),
        nameof(Bar),
        nameof(Baz),
    });
}
```

## オリジナルドキュメント

本ドキュメントは下記のオリジナルドキュメントを元に加筆修正を行ったものです。

[Livet Project Home](http://ugaya40.hateblo.jp/entry/Livet)

## 今後のサポート方針

基本的に WPF がサポートされているプラットフォームに対する対応を行います。
新機能の積極的な追加などは行う予定はありません。

新機能が必要な場合は PullRequest をお願いします。機能追加の PullRequest には単体テストをつけて動作確認が出来る状態でお願いします。

Issue にはなるべく目を通すつもりですが、メール通知などを見落とすことがあります。
ノーレスポンスにするつもりはないので、もし一週間程度反応が無い場合は Twitter の @okazuki 宛にメンションください。気付くまで定期的に送ることをお勧めします。

# Authors/Mentainers

- Original author: 尾上 雅則 (Masanori Onoue) Twitter ID: ugaya40
- Mentainer: 大田　一希（Kazuki Ota） Twitter ID: okazuki

