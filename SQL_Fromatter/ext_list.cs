using System;
using System.Collections.Generic;

namespace SQL_Fromatter
{
    class Ext_list<T> : List<T>
    {
        public event EventHandler<ListEventArgs> CountChanged;

        public new void Add(T item)
        {
            base.Add(item);

            CountChanged?.Invoke(this, new Ext_list<T>.ListEventArgs(this.Count));
        }

        public new void AddRange(IEnumerable<T> collection)
        {
            base.AddRange(collection);
            
            CountChanged?.Invoke(this, new Ext_list<T>.ListEventArgs(this.Count));
        }

        public new void Clear()
        {
            base.Clear();
            
            CountChanged?.Invoke(this, new Ext_list<T>.ListEventArgs(this.Count));
        }

        public new void Remove(T item)
        {
            base.Remove(item);
            
            CountChanged?.Invoke(this, new Ext_list<T>.ListEventArgs(this.Count));
        }

        public class ListEventArgs : EventArgs
        {
            public int Count { get; set; }

            public ListEventArgs(int anzahl)
            {
                this.Count = anzahl;
            }
        }
    }
}