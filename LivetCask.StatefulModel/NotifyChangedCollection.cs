using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livet.StatefulModel
{
    internal static class EventArguments
    {
        public static readonly PropertyChangedEventArgs CountPropertyChangedEventArgs = new PropertyChangedEventArgs("Count");
        public static readonly PropertyChangedEventArgs ItemPropertyChangedEventArgs = new PropertyChangedEventArgs("Item[]");
    }


    public class NotifyChangedCollection<T>:IList<T>, IList, IReadOnlyList<T>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        private readonly IList<T> _list;

        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public NotifyChangedCollection() : this(Enumerable.Empty<T>()) { }

        public NotifyChangedCollection(IEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            _list = new List<T>(source);
        }

        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)_list.ToArray()).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        protected virtual void InsertItem(int index,T newItem)
        {
            _list.Insert(index,newItem);
            PropertyChanged?.Invoke(this, EventArguments.CountPropertyChangedEventArgs);
            PropertyChanged?.Invoke(this, EventArguments.ItemPropertyChangedEventArgs);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add,newItem,index));
        }

        protected virtual void RemoveItem(int index)
        {
            var item = _list[index];
            _list.RemoveAt(index);
            PropertyChanged?.Invoke(this, EventArguments.CountPropertyChangedEventArgs);
            PropertyChanged?.Invoke(this, EventArguments.ItemPropertyChangedEventArgs);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
        }

        protected virtual void ReplaceItem(int index,T newItem)
        {
            var oldItem = _list[index];
            _list[index] = newItem;
            PropertyChanged?.Invoke(this, EventArguments.ItemPropertyChangedEventArgs);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, newItem, oldItem, index));
        }

        protected virtual void MoveItem(int oldIndex,int newIndex)
        {
            var item = _list[oldIndex];
            _list.RemoveAt(oldIndex);
            _list.Insert(newIndex,item);
            PropertyChanged?.Invoke(this, EventArguments.ItemPropertyChangedEventArgs);
            CollectionChanged?.Invoke(this,new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Move,item,newIndex,oldIndex));
        }

        protected virtual void ClearItems()
        {
            if(_list.Count == 0) return;
            _list.Clear();
            PropertyChanged?.Invoke(this, EventArguments.CountPropertyChangedEventArgs);
            PropertyChanged?.Invoke(this, EventArguments.ItemPropertyChangedEventArgs);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
        }

        public int Count => _list.Count;

        public bool IsReadOnly { get; } = false;

        public T this[int index]
        {
            get { return _list[index]; }

            set { ReplaceItem(index,value); }
        }

        public int IndexOf(T item) => _list.IndexOf(item);

        public void Insert(int index, T item) => InsertItem(index, item);

        public void RemoveAt(int index) => RemoveItem(index);

        public void Add(T item) => InsertItem(_list.Count, item);

        public void Clear() => ClearItems();

        public bool Contains(T item) => _list.Contains(item);

        public void CopyTo(T[] array, int arrayIndex) => _list.CopyTo(array, arrayIndex);

        public bool Remove(T item)
        {
            if (!_list.Contains(item)) return false;
            RemoveItem(_list.IndexOf(item));
            return true;
        }

        #region ICollection(non-generic) support
        void ICollection.CopyTo(Array array, int index) => CopyTo(array.Cast<T>().ToArray(), index);
        bool ICollection.IsSynchronized { get; } = false;
        object ICollection.SyncRoot { get; } = new object();
        #endregion

        #region IList(non-generic) support
        object IList.this[int index]
        {
            get { return _list[index]; }
            set { this[index] = (T)value; }
        }
        void IList.Remove(object value) => Remove((T)value);
        bool IList.IsFixedSize { get; } = false;
        int IList.Add(object value)
        {
            Add((T)value);
            return _list.Count - 1;
        }
        bool IList.Contains(object value) => Contains((T)value);
        int IList.IndexOf(object value) => IndexOf((T)value);
        void IList.Insert(int index, object value) => Insert(index, (T)value);
        #endregion
    }
}
