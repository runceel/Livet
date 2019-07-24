using System.Windows;
using Livet.Annotations;

namespace Livet.Messaging
{
    public class GenericInteractionMessage<T> : InteractionMessage
    {
        // Using a DependencyProperty as the backing store for Value.  This enables animation, styling, binding, etc...
        [NotNull] public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register("Value", typeof(T), typeof(GenericInteractionMessage<T>),
                new PropertyMetadata(default(T)));

        public GenericInteractionMessage(T value, string messageKey) : base(messageKey)
        {
            Value = value;
        }

        public GenericInteractionMessage(T value) : this(value, null) { }

        public T Value
        {
            get { return (T) GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        protected override Freezable CreateInstanceCore()
        {
            return new GenericInteractionMessage<T>(Value, MessageKey);
        }
    }
}