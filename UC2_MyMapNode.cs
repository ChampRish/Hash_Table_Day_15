using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_Day15_Assignment_
{
    class UC2_MyMapNode<K, V>
    {
        private readonly int size;
        private readonly LinkedList<UC3_KeyValue<K, V>>[] items;

        public UC2_MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<UC3_KeyValue<K, V>>[size];
        }


        protected int GetPositionInArray(K key)
        {
            return Math.Abs(key.GetHashCode() % size);
        }
        protected LinkedList<UC3_KeyValue<K, V>> LinkedListBuilder(int position)
        {
            var linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<UC3_KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }


        public void AddValue(K key, V value)
        {
            int position = GetPositionInArray(key);
            var linkedList = LinkedListBuilder(position);
            var item = new UC3_KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
        }

        public V GetValue(K key)
        {
            int position = GetPositionInArray(key);
            var linkedList = LinkedListBuilder(position);
            foreach (var item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
        public void SetValue(K key, V value)
        {
            int position = GetPositionInArray(key);
            var linkedList = LinkedListBuilder(position);
            UC3_KeyValue<K, V> temp = new UC3_KeyValue<K, V>();
            foreach (var item in linkedList)
            {
                if (item.Key.Equals(key))
                    temp = item;
            }
            temp.Value = value;
        }

    }
}
    



