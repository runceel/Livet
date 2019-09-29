using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Input;
using Livet.Annotations;

namespace Livet.Commands
{
    /// <summary>
    ///     ViewModelがViewに公開するコマンドを表します。
    /// </summary>
    public sealed class ViewModelCommand : Command, ICommand, INotifyPropertyChanged
    {
        [CanBeNull] private readonly Func<bool> _canExecute;
        [NotNull] private readonly Action _execute;

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        /// <param name="execute">コマンドが実行するAction</param>
        public ViewModelCommand([NotNull] Action execute) : this(execute, null) { }

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        /// <param name="execute">コマンドが実行するAction</param>
        /// <param name="canExecute">コマンドが実行可能かどうかをあらわすFunc&lt;bool&gt;</param>
        public ViewModelCommand([NotNull] Action execute, [CanBeNull] Func<bool> canExecute)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        /// <summary>
        ///     コマンドが実行可能かどうかを取得します。
        /// </summary>
        public bool CanExecute
        {
            get { return _canExecute?.Invoke() ?? true; }
        }

        void ICommand.Execute(object parameter)
        {
            Execute();
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
        public void Execute()
        {
            _execute();
        }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged()
        {
            Interlocked.CompareExchange(ref PropertyChanged, null, null)
                ?.Invoke(this, EventArgsFactory.GetPropertyChangedEventArgs("CanExecute"));
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