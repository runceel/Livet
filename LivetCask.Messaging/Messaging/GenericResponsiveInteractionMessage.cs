using System.Windows;
using Livet.Annotations;

namespace Livet.Messaging
{
    public class GenericResponsiveInteractionMessage<TValue, TResponse> : ResponsiveInteractionMessage<TResponse>
    {
        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(TValue),
                typeof(GenericResponsiveInteractionMessage<TValue, TResponse>), new PropertyMetadata(default(TValue)));

        public GenericResponsiveInteractionMessage(TValue value, string messageKey) : base(messageKey)
        {
            Value = value;
        }

        public GenericResponsiveInteractionMessage(TValue value) : this(value, null) { }

        public TValue Value
        {
            get { return (TValue) GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        protected override Freezable CreateInstanceCore()
        {
            return new GenericResponsiveInteractionMessage<TValue, TResponse>(Value, MessageKey);
        }
    }
}