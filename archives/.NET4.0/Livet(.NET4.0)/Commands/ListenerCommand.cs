using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Input;

namespace Livet.Commands
{
    /// <summary>
    /// ViewModelにおいて、Viewからメッセージ、あるいはオブジェクトを受け取って動作するコマンドを表します。
    /// </summary>
    /// <typeparam name="T">Viewから受け取るオブジェクトの型</typeparam>
    public sealed class ListenerCommand<T> :Command,ICommand,INotifyPropertyChanged
    {
        Action<T> _execute;
        Func<bool> _canExecute;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="execute">コマンドが実行するAction</param>
        public ListenerCommand(Action<T> execute) : this(execute, null) { }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="execute">コマンドが実行するAction</param>
        /// <param name="canExecute">コマンドが実行可能かどうかをあらわすFunc&lt;bool&gt;</param>
        public ListenerCommand(Action<T> execute, Func<bool> canExecute)
        {
            if (execute == null) throw new ArgumentNullException("execute");

            _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        /// コマンドが実行可能かどうかを取得します。
        /// </summary>
        public bool CanExecute
        {
            get { return _canExecute == null ? true : _canExecute(); }
        }

        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        /// <param name="parameter">Viewから渡されたオブジェクト</param>
        public void Execute(T parameter)
        {
            _execute(parameter);
        }

        void ICommand.Execute(object parameter)
        {
            if (parameter == null)
            {
                Execute(default(T));
            }
            else
            {
                Execute((T)parameter);
            }
        }

        bool ICommand.CanExecute(object parameter)
        {
            return CanExecute;
        }

        /// <summary>
        /// コマンドが実行可能かどうかが変化した時に発生します。
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged()
        {
            var handler = Interlocked.CompareExchange(ref PropertyChanged, null, null);
            if (handler != null)
            {
                handler(this,EventArgsFactory.GetPropertyChangedEventArgs("CanExecute"));
            }
        }

        /// <summary>
        /// コマンドが実行可能かどうかが変化したことを通知します。
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
        public void RaiseCanExecuteChanged()
        {
            OnPropertyChanged();
            OnCanExecuteChanged();
        }

    }
}
