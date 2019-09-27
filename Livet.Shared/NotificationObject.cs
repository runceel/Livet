using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using Livet.Annotations;

namespace Livet
{
    /// <summary>
    ///     変更通知オブジェクトの基底クラスです。
    /// </summary>
    [Serializable]
    public class NotificationObject : INotifyPropertyChanged
    {
        /// <summary>
        ///     プロパティ変更通知イベントです。
        /// </summary>
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     プロパティ変更通知イベントを発生させます。
        /// </summary>
        /// <param name="source"></param>
        /// <param name="propertyExpression">() => プロパティ形式のラムダ式</param>
        /// <exception cref="NotSupportedException">() => プロパティ 以外の形式のラムダ式が指定されました。</exception>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures")]
        [NotifyPropertyChangedInvocator]
        // ReSharper disable once UnusedParameter.Global
        protected virtual void RaisePropertyChanged<T>(ref T source, [NotNull] Expression<Func<T>> propertyExpression)
        {
            if (propertyExpression == null) throw new ArgumentNullException(nameof(propertyExpression));

            if (!(propertyExpression.Body is MemberExpression))
                throw new NotSupportedException("このメソッドでは ()=>プロパティ の形式のラムダ式以外許可されません");

            var memberExpression = (MemberExpression) propertyExpression.Body;
            RaisePropertyChanged(memberExpression.Member.Name);
        }

        /// <summary>
        ///     プロパティ変更通知イベントを発生させます
        /// </summary>
        /// <param name="propertyName">プロパティ名</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1030:UseEventsWhereAppropriate")]
        [NotifyPropertyChangedInvocator]
        protected virtual void RaisePropertyChanged([CallerMemberName] [CanBeNull] string propertyName = "")
        {
            var threadSafeHandler = Interlocked.CompareExchange(ref PropertyChanged, null, null);
            threadSafeHandler?.Invoke(this, EventArgsFactory.GetPropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        ///     前と値が違うなら変更して、プロパティ変更通知イベントを発生させます
        /// </summary>
        /// <typeparam name="T">プロパティの型</typeparam>
        /// <param name="source">元の値</param>
        /// <param name="value">新しい値</param>
        /// <param name="relatedProperties">このプロパティが変更されたときに PropertyChanged イベントを発行するプロパティの名前の配列</param>
        /// <param name="propertyName">プロパティ名</param>
        /// <returns>値の変更有無</returns>
        [NotifyPropertyChangedInvocator]
        protected bool RaisePropertyChangedIfSet<T>(ref T source, T value, string[] relatedProperties = null,
            [CallerMemberName] string propertyName = null)
        {
            //値が同じだったら何もしない
            if (EqualityComparer<T>.Default.Equals(source, value))
                return false;

            source = value;
            RaisePropertyChanged(propertyName);
            if (relatedProperties == null) return true;

            foreach (var p in relatedProperties)
                RaisePropertyChanged(p);

            return true;
        }

        /// <summary>
        ///     前と値が違うなら変更して、プロパティ変更通知イベントを発生させます
        /// </summary>
        /// <typeparam name="T">プロパティの型</typeparam>
        /// <param name="source">元の値</param>
        /// <param name="value">新しい値</param>
        /// <param name="relatedProperty">このプロパティが変更されたときに PropertyChanged イベントを発行するプロパティの名前</param>
        /// <param name="propertyName">プロパティ名</param>
        /// <returns>値の変更有無</returns>
        [NotifyPropertyChangedInvocator]
        protected bool RaisePropertyChangedIfSet<T>(ref T source, T value, string relatedProperty,
            [CallerMemberName] string propertyName = null)
        {
            return RaisePropertyChangedIfSet(ref source, value, new[] {relatedProperty}, propertyName);
        }
    }
}