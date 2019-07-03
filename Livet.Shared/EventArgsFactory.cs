using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using Livet.Annotations;

namespace Livet
{
    internal static class EventArgsFactory
    {
        [NotNull] private static readonly ConcurrentDictionary<string, PropertyChangedEventArgs>
            PropertyChangedEventArgsDictionary = new ConcurrentDictionary<string, PropertyChangedEventArgs>();

        public static PropertyChangedEventArgs GetPropertyChangedEventArgs([NotNull] string propertyName)
        {
            if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));

            return PropertyChangedEventArgsDictionary.GetOrAdd(propertyName,
                name => new PropertyChangedEventArgs(name));
        }
    }
}