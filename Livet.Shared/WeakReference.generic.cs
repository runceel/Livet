using System;
using Livet.Annotations;

namespace Livet
{
    public class WeakReference<T> where T : class
    {
        [NotNull] private readonly WeakReference _targetWeakReference;

        public WeakReference([CanBeNull] T target)
        {
            _targetWeakReference = new WeakReference(target);
        }

        public bool TryGetTarget([CanBeNull] out T target)
        {
            var result = _targetWeakReference.Target as T;

            target = result;

            return target != null;
        }
    }
}