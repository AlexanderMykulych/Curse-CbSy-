using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1 {
    class Comparer : IComparer<string>{

        public int Compare(string x, string y) {
            return 0 - x.CompareTo(y);
        }
    }
}
