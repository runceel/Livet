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

using Livet.Messaging;
using Livet.Behaviors.Messaging;


namespace $rootnamespace$
{
    public class $safeitemname$ : InteractionMessageAction<FrameworkElement>
    {
        protected override void InvokeAction(Livet.Messaging.InteractionMessage m)
        {
            //// Convert to a message expected by this action
            //var confirmMessage = m as ConfirmationMessage;

            //if (confirmMessage != null)
            //{
            //    // Execute action using received the message
            //    var result = MessageBox.Show(
            //        confirmMessage.Text,
            //        confirmMessage.Caption,
            //        confirmMessage.Button,
            //        confirmMessage.Image
            //        );

            //    // If message has a return value, then set a response
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
