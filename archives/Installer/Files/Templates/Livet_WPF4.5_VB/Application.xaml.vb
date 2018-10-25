Class Application

    ' Startup、Exit、DispatcherUnhandledException などのアプリケーション レベルのイベントは、
    ' このファイルで処理できます。

    Private Sub Application_Startup(sender As Object, e As System.Windows.StartupEventArgs) Handles Me.Startup
        DispatcherHelper.UIDispatcher = Me.Dispatcher
    End Sub

    '集約エラーハンドラ
    'Private Sub Application_DispatcherUnhandledException(sender As Object, e As System.Windows.Threading.DispatcherUnhandledExceptionEventArgs) Handles Me.DispatcherUnhandledException
    '    'TODO:ロギング処理など
	'
    '    MessageBox.Show("不明なエラーが発生しました。アプリケーションを終了します。",
    '                    "エラー",
    '                    MessageBoxButton.OK,
    '                    MessageBoxImage.Error)
	'
    '    Environment.Exit(1)
    'End Sub
End Class
