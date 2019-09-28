using System;
using System.Windows;
using Microsoft.Xaml.Behaviors;
using Livet.Annotations;

namespace Livet.Behaviors
{
    /// <summary>
    ///     引数を一つだけ持つメソッドに対応したCallMethodActionです。
    /// </summary>
    public class LivetCallMethodAction : TriggerAction<DependencyObject>
    {
        // Using a DependencyProperty as the backing store for MethodTarget.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty MethodTargetProperty =
            DependencyProperty.Register("MethodTarget", typeof(object), typeof(LivetCallMethodAction),
                new PropertyMetadata(null));

        // Using a DependencyProperty as the backing store for MethodName.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty MethodNameProperty =
            DependencyProperty.Register("MethodName", typeof(string), typeof(LivetCallMethodAction),
                new PropertyMetadata(null));

        // Using a DependencyProperty as the backing store for MethodParameter.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty MethodParameterProperty =
            DependencyProperty.Register("MethodParameter", typeof(object), typeof(LivetCallMethodAction),
                new PropertyMetadata(null, OnMethodParameterChanged));

        [NotNull] private readonly MethodBinderWithArgument _callbackMethod = new MethodBinderWithArgument();
        [NotNull] private readonly MethodBinder _method = new MethodBinder();

        private bool _parameterSet;

        /// <summary>
        ///     メソッドを呼び出すオブジェクトを指定、または取得します。
        /// </summary>
        public object MethodTarget
        {
            get { return GetValue(MethodTargetProperty); }
            set { SetValue(MethodTargetProperty, value); }
        }

        /// <summary>
        ///     呼び出すメソッドの名前を指定、または取得します。
        /// </summary>
        public string MethodName
        {
            get { return (string) GetValue(MethodNameProperty); }
            set { SetValue(MethodNameProperty, value); }
        }

        /// <summary>
        ///     呼び出すメソッドに渡す引数を指定、または取得します。
        /// </summary>
        public object MethodParameter
        {
            get { return GetValue(MethodParameterProperty); }
            set { SetValue(MethodParameterProperty, value); }
        }

        private static void OnMethodParameterChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var action = sender as LivetCallMethodAction
                         ?? throw new ArgumentException(
                             $"Value must be a {nameof(LivetCallMethodAction)}.",
                             nameof(sender));

            action._parameterSet = true;
        }

        protected override void Invoke(object parameter)
        {
            if (MethodTarget == null) return;
            if (MethodName == null) return;

            if (!_parameterSet)
                _method.Invoke(MethodTarget, MethodName);
            else
                _callbackMethod.Invoke(MethodTarget, MethodName, MethodParameter);
        }
    }
}