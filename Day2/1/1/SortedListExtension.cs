using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1 {
    public static class SortedListExtension {
        public static void Write<TKey, TValue>(this SortedList<TKey, TValue> list) {
            foreach (var item in list) {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }
        }
    }
}
