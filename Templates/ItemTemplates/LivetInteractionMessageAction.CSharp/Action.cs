using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows.Interactivity;

using Livet.Messaging;
using Livet.Behaviors.Messaging;


namespace $rootnamespace$
{
	//Tはこのアクションがアタッチできる型を表します。
	//この場合はこのアクションはFrameworkElementにアタッチできます。
    public class $safeitemname$ : InteractionMessageAction<FrameworkElement>
    {
        protected override void InvokeAction(Livet.Messaging.InteractionMessage m)
        {
            ////このアクションが対応するメッセージに変換します。
            //var confirmMessage = m as ConfirmationMessage;

            //if (confirmMessage != null)
            //{
            //    //受け取ったメッセージの情報を使用して実行したいアクションを実行します。
            //    var result = MessageBox.Show(
            //        confirmMessage.Text,
            //        confirmMessage.Caption,
            //        confirmMessage.Button,
            //        confirmMessage.Image
            //        );

            //    //戻り値のあるメッセージの場合、戻り値を設定します。
            //    if (result == MessageBoxResult.Yes || result == MessageBoxResult.OK)
            //    {
            //        confirmMessage.Response = true;
            //    }
            //    else
            //    {
            //        confirmMessage.Response = false;
            //    }
            //}
        }
    }
}
