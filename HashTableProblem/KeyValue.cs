using System;
using System.Collections.Generic;
using System.Text;

namespace HashTableProblem
{
    public struct KeyValue<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
    }
}
