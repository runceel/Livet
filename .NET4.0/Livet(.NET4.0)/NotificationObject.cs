using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Livet
{
    /// <summary>
    /// 変更通知オブジェクトの基底クラスです。
    /// </summary>
    [Serializable]
    public class NotificationObject : INotifyPropertyChanged
    {
        /// <summary>
        /// プロパティ変更通知イベントです。
        /// </summary>
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// プロパティ変更通知イベントを発生させます。
        /// </summary>
        /// <param name="propertyExpression">() => プロパティ形式のラムダ式</param>
        /// <exception cref="NotSupportedException">() => プロパティ 以外の形式のラムダ式が指定されました。</exception>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        protected virtual void RaisePropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            if (propertyExpression == null) throw new ArgumentNullException("propertyExpression");

            if (!(propertyExpression.Body is MemberExpression)) throw new NotSupportedException("このメソッドでは ()=>プロパティ の形式のラムダ式以外許可されません");

            var memberExpression = (MemberExpression)propertyExpression.Body;
            RaisePropertyChanged(memberExpression.Member.Name);
        }

        /// <summary>
        /// プロパティ変更通知イベントを発生させます
        /// </summary>
        /// <param name="propertyName">プロパティ名</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
#if NET4
        protected virtual void RaisePropertyChanged(string propertyName)
#elif NET45
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName="")
#endif
        {
            var threadSafeHandler = Interlocked.CompareExchange(ref PropertyChanged,null,null);
            if (threadSafeHandler != null)
            {
                var e = EventArgsFactory.GetPropertyChangedEventArgs(propertyName);
                threadSafeHandler(this, e);
            }
        }

        /// <summary>
        /// 前と値が違うなら変更してイベントを発行する
        /// </summary>
        /// <typeparam name="TResult">プロパティの型</typeparam>
        /// <param name="source">元の値</param>
        /// <param name="value">新しい値</param>
        /// <param name="propertyName">プロパティ名/param>
        /// <returns>値の変更有無</returns>
#if NET4
        protected bool RaisePropertyChangedIfSet<TResult>(ref TResult source, TResult value, string propertyName)
#elif NET45
        protected bool RaisePropertyChangedIfSet<TResult>(ref TResult source, TResult value, [CallerMemberName]string propertyName = null)
#endif
        {
            //値が同じだったら何もしない
            if (EqualityComparer<TResult>.Default.Equals(source, value))
                return false;

            source = value;
            //イベント発行
            RaisePropertyChanged(propertyName);
            return true;
        }
    }
}
