using System.Collections.Concurrent;
using System.ComponentModel;
using Livet.Annotations;

namespace Livet
{
    internal static class EventArgsFactory
    {
        [NotNull] private static readonly ConcurrentDictionary<string, PropertyChangedEventArgs>
            PropertyChangedEventArgsDictionary = new ConcurrentDictionary<string, PropertyChangedEventArgs>();

        public static PropertyChangedEventArgs GetPropertyChangedEventArgs([CanBeNull] string propertyName)
        {
            return PropertyChangedEventArgsDictionary.GetOrAdd(propertyName ?? string.Empty,
                name => new PropertyChangedEventArgs(name));
        }
    }
}