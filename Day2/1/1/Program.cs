using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _1 {
    class Program {
        static void Main(string[] args) {
            var list = new SortedList<string, string>() { { "asd", "123" }, { "qwe", "456" } };
            list.Write();
            Console.WriteLine("_______________________________");
            var descList = new SortedList<string, string>(list, new Comparer());
            descList.Write();
            Console.ReadKey();
        }

    }
}
