'Tはこのアクションがアタッチできる型を表します。
'この場合はこのアクションはFrameworkElementにアタッチできます。
Public Class $safeitemname$
    Inherits InteractionMessageAction(Of FrameworkElement)

    Protected Overrides Sub InvokeAction(ByVal m As InteractionMessage)
        'このアクションが対応するメッセージに変換します。
        'Dim confirmMessage = TryCast(m, ConfirmationMessage)

        'If confirmMessage IsNot Nothing
        '   受け取ったメッセージの情報を使用して実行したいアクションを実行します。
        '   Dim result = MessageBox.Show(
        '       confirmMessage.Text,
        '       confirmMessage.Caption,
        '       confirmMessage.Button,
        '       confirmMessage.Image)

        '   戻り値のあるメッセージの場合、戻り値を設定します。
        '   If result = MessageBoxResult.Yes OrElse result = MessageBoxResult.OK
        '       confirmMessage.Response = true
        '   Else
        '       confirmMessage.Response = false
        '   End If
        'End If
    End Sub
End Class