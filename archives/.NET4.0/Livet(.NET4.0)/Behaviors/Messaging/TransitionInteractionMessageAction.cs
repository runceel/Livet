using System;
using System.Linq;
using Livet.Messaging;
using System.Windows;

namespace Livet.Behaviors.Messaging
{
    /// <summary>
    /// 画面遷移(Window)を行うアクションです。<see cref="TransitionMessage"/>に対応します。
    /// </summary>
    public class TransitionInteractionMessageAction : InteractionMessageAction<FrameworkElement>
    {
        /// <summary>
        /// 遷移するウインドウの型を指定、または取得します。
        /// </summary>
        public Type WindowType
        {
            get { return (Type)GetValue(WindowTypeProperty); }
            set { SetValue(WindowTypeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for WindowType.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty WindowTypeProperty =
            DependencyProperty.Register("WindowType", typeof(Type), typeof(TransitionInteractionMessageAction), new PropertyMetadata());

        private static bool IsValidWindowType(Type value)
        {
            if (value != null)
            {
                if (value.IsSubclassOf(typeof(Window)))
                {
                    return value.GetConstructor(Type.EmptyTypes) != null;
                }
            }

            return false;
        }

        /// <summary>
        /// 画面遷移の種類を指定するTransitionMode列挙体を指定、または取得します。<br/>
        /// TransitionMessageでModeがUnKnown以外に指定されていた場合、そちらが優先されます。
        /// </summary>
        public TransitionMode Mode
        {
            get { return (TransitionMode)GetValue(ModeProperty); }
            set { SetValue(ModeProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Mode.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ModeProperty =
            DependencyProperty.Register("Mode", typeof(TransitionMode), typeof(TransitionInteractionMessageAction), new PropertyMetadata(TransitionMode.Normal));

        /// <summary>
        /// 遷移先ウィンドウがこのウィンドウに所有されるかを設定します。
        /// </summary>
        public bool IsOwned
        {            
            get { return (bool)GetValue(OwnedFromThisProperty); }
            set { SetValue(OwnedFromThisProperty, value); }
        }
        
        // Using a DependencyProperty as the backing store for OwnedFromThis.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OwnedFromThisProperty = 
            DependencyProperty.Register("IsOwned", typeof(bool), typeof(TransitionInteractionMessageAction), new PropertyMetadata(true));

        protected override void InvokeAction(InteractionMessage message)
        {
            var transitionMessage = message as TransitionMessage;

            if (transitionMessage == null) return;

            Type targetType;

            if (transitionMessage.WindowType != null)
            {
                targetType = transitionMessage.WindowType;
            }
            else
            {
                targetType = WindowType;
            }

            if (!IsValidWindowType(targetType))
            {
                return;
            }

            var defaultConstructor = targetType.GetConstructor(Type.EmptyTypes);

            if (Mode == TransitionMode.UnKnown && transitionMessage.Mode == TransitionMode.UnKnown)
            {
                return;
            }

            var mode = transitionMessage.Mode == TransitionMode.UnKnown ? Mode : transitionMessage.Mode;

            switch (mode)
            {
                case TransitionMode.Normal:
                case TransitionMode.Modal:
                    var targetWindow = (Window)defaultConstructor.Invoke(null);
                    if (transitionMessage.TransitionViewModel != null)
                    {
                        targetWindow.DataContext = transitionMessage.TransitionViewModel;
                    }

                    if (IsOwned)
                    {
                        targetWindow.Owner = Window.GetWindow(AssociatedObject);
                    }

                    if (mode == TransitionMode.Normal)
                    {
                        targetWindow.Show();
                        transitionMessage.Response = null;
                    }
                    else
                    {
                        transitionMessage.Response = targetWindow.ShowDialog();
                    }

                    break;
                case TransitionMode.NewOrActive:
                    var window = Application.Current.Windows
                        .OfType<Window>()
                        .FirstOrDefault(w => w.GetType() == targetType);

                    if (window == null)
                    {
                        window = (Window)defaultConstructor.Invoke(null);

                        if (transitionMessage.TransitionViewModel != null)
                        {
                            window.DataContext = transitionMessage.TransitionViewModel;
                        }
                        if (IsOwned)
                        {
                            window.Owner = Window.GetWindow(AssociatedObject);
                        }
                        window.Show();
                        transitionMessage.Response = null;
                    }
                    else
                    {
                        if (transitionMessage.TransitionViewModel != null)
                        {
                            window.DataContext = transitionMessage.TransitionViewModel;
                        }
                        if (IsOwned)
                        {
                            window.Owner = Window.GetWindow(AssociatedObject);
                        }
                        window.Activate();
                        // 最小化中なら戻す
                        if (window.WindowState == WindowState.Minimized)
                        {
                            window.WindowState = WindowState.Normal;
                        }
                        transitionMessage.Response = null;
                    }

                    break;
            }
            
        }

    }
}
