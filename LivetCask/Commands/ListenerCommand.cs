using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Input;
using Livet.Annotations;

namespace Livet.Commands
{
    /// <summary>
    ///     ViewModelにおいて、Viewからメッセージ、あるいはオブジェクトを受け取って動作するコマンドを表します。
    /// </summary>
    /// <typeparam name="T">Viewから受け取るオブジェクトの型</typeparam>
    public sealed class ListenerCommand<T> : Command, ICommand, INotifyPropertyChanged
    {
        [CanBeNull] private readonly Func<bool> _canExecute;
        [NotNull] private readonly Action<T> _execute;

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        /// <param name="execute">コマンドが実行するAction</param>
        public ListenerCommand([NotNull] Action<T> execute) : this(execute, null) { }

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        /// <param name="execute">コマンドが実行するAction</param>
        /// <param name="canExecute">コマンドが実行可能かどうかをあらわすFunc&lt;bool&gt;</param>
        public ListenerCommand([NotNull] Action<T> execute, [CanBeNull] Func<bool> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        /// <summary>
        ///     コマンドが実行可能かどうかを取得します。
        /// </summary>
        public bool CanExecute
        {
            get { return _canExecute == null || _canExecute(); }
        }

        void ICommand.Execute(object parameter)
        {
            if (parameter == null)
                Execute(default);
            else
                Execute((T) parameter);
        }

        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute;
        }

        /// <summary>
        ///     コマンドが実行可能かどうかが変化した時に発生します。
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     コマンドを実行します。
        /// </summary>
        /// <param name="parameter">Viewから渡されたオブジェクト</param>
        public void Execute(T parameter)
        {
            _execute(parameter);
        }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged()
        {
            var handler = Interlocked.CompareExchange(ref PropertyChanged, null, null);
            handler?.Invoke(this, EventArgsFactory.GetPropertyChangedEventArgs("CanExecute"));
        }

        /// <summary>
        ///     コマンドが実行可能かどうかが変化したことを通知します。
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
        public void RaiseCanExecuteChanged()
        {
            OnPropertyChanged();
            OnCanExecuteChanged();
        }
    }
}