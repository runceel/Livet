using System;

namespace Livet
{
    public class WeakReference<T> where T : class
    {
        private WeakReference _targetWeakReference;

        public WeakReference(T target)
        {
            _targetWeakReference = new WeakReference(target);
        }

        public bool TryGetTarget(out T target)
        {
            var result = _targetWeakReference.Target as T;

            target = result;

            return target != null;
        }
    }
}
