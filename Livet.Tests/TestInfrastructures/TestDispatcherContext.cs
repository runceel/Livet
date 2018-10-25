using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Threading.Tasks;
using System.Threading;

namespace Livet.NUnit
{
    public class TestDispatcherContext : IDisposable
    {
        private Dispatcher _dispatcher = null;
        private bool _disposed = false;

        public TestDispatcherContext()
        {
            var dispatcherRunFlag = false;

            Task.Factory.StartNew(() =>
            {
                _dispatcher = Dispatcher.CurrentDispatcher;
                Dispatcher.Run();
            }, TaskCreationOptions.LongRunning);

            while (_dispatcher == null) { Thread.Sleep(10); }

            _dispatcher.BeginInvoke(((Action)(() => dispatcherRunFlag = true)));

            while (!dispatcherRunFlag) { Thread.Sleep(10); }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Dispatcher Dispatcher
        {
            get
            {
                ThrowExceptionIfDisposed();
                return _dispatcher;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                if (_dispatcher != null && !(_dispatcher.HasShutdownStarted || _dispatcher.HasShutdownFinished))
                {
                    _dispatcher.InvokeShutdown();
                }
            }
            _disposed = true;
        }

        protected void ThrowExceptionIfDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException("DispatcherContext");
            }
        }
    }
}
