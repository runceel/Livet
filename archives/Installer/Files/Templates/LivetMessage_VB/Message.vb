'戻り値のある相互作用メッセージはResponsiveInteractionMessage(Of T)を継承して作成します。
'Tは戻り値の型です。
'戻り値のない相互作用メッセージはInteractionMessageを継承して作成します。
Public Class $safeitemname$
    Inherits ResponsiveInteractionMessage(Of String)

    'Viewでメッセージインスタンスを生成する時のためのコンストラクタ
    Public Sub New()

    End Sub

    'ViewModelからMessenger経由での発信目的でメッセージインスタンスを生成するためのコンストラクタ
    Public Sub New(ByVal messageKey As String)
        MyBase.New(messageKey)
    End Sub
    
    'メッセージに保持させたい情報をプロパティとして定義してください。
    'Viewでバインド可能なプロパティにするために依存関係プロパティとして定義する事をお勧めします。
    '通常依存関係プロパティはコードスニペット propdpを使用して定義します。
    'もし普通のプロパティとして定義したい場合はコードスニペット propを使用して定義します。
    
    ''' <summary>
    ''' 派生クラスでは必ずオーバーライドしてください。Freezableオブジェクトとして必要な実装です。<br/>
    ''' 通常このメソッドは、自身の新しいインスタンスを返すように実装します。
    ''' </summary>
    ''' <returns>自身の新しいインスタンス</returns>
    Protected Overrides Function CreateInstanceCore() As System.Windows.Freezable
        Return New $safeitemname$()
    End Function
End Class