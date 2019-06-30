using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

using Livet.Messaging;

namespace $rootnamespace$
{
    /*
     * ResponsiveInteractionMessage<T> is for a message that has return value.
     * The type parameter is a type of return value.
     * If message doesn't have a return value, then please use InteractionMessage.
     */
    public class $safeitemname$ : ResponsiveInteractionMessage<string>
    {
        // This is a constructor for to create this instance at View layer.
        public $safeitemname$()
        {
        }

        // This is a construcot when using to create this instance at ViewModel layer to send it using Messenger class.
        public $safeitemname$(string messageKey)
            : base(messageKey)
        {

        }

        /*
         * Define some properties if you need using propdp code snippets.
         */

        /// <summary>
        /// Please do not remove this method.
        /// </summary>
        /// <returns>A new instance of this.</returns>
        protected override System.Windows.Freezable CreateInstanceCore()
        {
            return new $safeitemname$();
        }
    }
}
