#If _MyType <> "Empty" Then

Namespace My
    ''' <summary>
    ''' WPF の My Namespace で使用できるプロパティを定義するためのモジュール
    ''' </summary>
    ''' <remarks></remarks>
    <Global.Microsoft.VisualBasic.HideModuleName()> _
    Module MyWpfExtension
        Private s_Computer As New ThreadSafeObjectProvider(Of Global.Microsoft.VisualBasic.Devices.Computer)
        Private s_User As New ThreadSafeObjectProvider(Of Global.Microsoft.VisualBasic.ApplicationServices.User)
        Private s_Windows As New ThreadSafeObjectProvider(Of MyWindows)
        Private s_Log As New ThreadSafeObjectProvider(Of Global.Microsoft.VisualBasic.Logging.Log)
        ''' <summary>
        ''' 実行中のアプリケーション用のアプリケーション オブジェクトを返します
        ''' </summary>
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend ReadOnly Property Application() As Application
            Get
                Return CType(Global.System.Windows.Application.Current, Application)
            End Get
        End Property
        ''' <summary>
        ''' ホスト コンピューターに関する情報を返します。
        ''' </summary>
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend ReadOnly Property Computer() As Global.Microsoft.VisualBasic.Devices.Computer
            Get
                Return s_Computer.GetInstance()
            End Get
        End Property
        ''' <summary>
        ''' 現在のユーザーに関する情報を返します。現在の
        ''' Windows ユーザー資格情報でアプリケーションを実行する場合は、My.User.InitializeWithWindowsUser() を呼び出してください。
        ''' </summary>
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend ReadOnly Property User() As Global.Microsoft.VisualBasic.ApplicationServices.User
            Get
                Return s_User.GetInstance()
            End Get
        End Property
        ''' <summary>
        ''' アプリケーション ログを返します。リスナーは、アプリケーションの構成ファイルを使用して構成できます。
        ''' </summary>
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend ReadOnly Property Log() As Global.Microsoft.VisualBasic.Logging.Log
            Get
                Return s_Log.GetInstance()
            End Get
        End Property

        ''' <summary>
        ''' プロジェクトで定義されている Windows の集合を返します。
        ''' </summary>
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend ReadOnly Property Windows() As MyWindows
            <Global.System.Diagnostics.DebuggerHidden()> _
            Get
                Return s_Windows.GetInstance()
            End Get
        End Property
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
        <Global.Microsoft.VisualBasic.MyGroupCollection("System.Windows.Window", "Create__Instance__", "Dispose__Instance__", "My.MyWpfExtenstionModule.Windows")> _
        Friend NotInheritable Class MyWindows
            <Global.System.Diagnostics.DebuggerHidden()> _
            Private Shared Function Create__Instance__(Of T As {New, Global.System.Windows.Window})(ByVal Instance As T) As T
                If Instance Is Nothing Then
                    If s_WindowBeingCreated IsNot Nothing Then
                        If s_WindowBeingCreated.ContainsKey(GetType(T)) = True Then
                            Throw New Global.System.InvalidOperationException("The window cannot be accessed via My.Windows from the Window constructor.")
                        End If
                    Else
                        s_WindowBeingCreated = New Global.System.Collections.Hashtable()
                    End If
                    s_WindowBeingCreated.Add(GetType(T), Nothing)
                    Return New T()
                    s_WindowBeingCreated.Remove(GetType(T))
                Else
                    Return Instance
                End If
            End Function
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1822:MarkMembersAsStatic")>  _
            <Global.System.Diagnostics.DebuggerHidden()> _
            Private Sub Dispose__Instance__(Of T As Global.System.Windows.Window)(ByRef instance As T)
                instance = Nothing
            End Sub
            <Global.System.Diagnostics.DebuggerHidden()> _
            <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            Public Sub New()
                MyBase.New()
            End Sub
            <Global.System.ThreadStatic()> Private Shared s_WindowBeingCreated As Global.System.Collections.Hashtable
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> Public Overrides Function Equals(ByVal o As Object) As Boolean
                Return MyBase.Equals(o)
            End Function
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> Public Overrides Function GetHashCode() As Integer
                Return MyBase.GetHashCode
            End Function
            <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1822:MarkMembersAsStatic")>  _
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> _
            Friend Overloads Function [GetType]() As Global.System.Type
                Return GetType(MyWindows)
            End Function
            <Global.System.ComponentModel.EditorBrowsable(Global.System.ComponentModel.EditorBrowsableState.Never)> Public Overrides Function ToString() As String
                Return MyBase.ToString
            End Function
        End Class
    End Module
End Namespace
Partial Class Application
    Inherits Global.System.Windows.Application
    <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
    <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1822:MarkMembersAsStatic")> _
    Friend ReadOnly Property Info() As Global.Microsoft.VisualBasic.ApplicationServices.AssemblyInfo
        <Global.System.Diagnostics.DebuggerHidden()> _
        Get
            Return New Global.Microsoft.VisualBasic.ApplicationServices.AssemblyInfo(Global.System.Reflection.Assembly.GetExecutingAssembly())
        End Get
    End Property
End Class
#End If