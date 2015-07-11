using _1.Enumerable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1 {
    class Program {
        static void Main(string[] args) {
            var collection = new MEnumerable() { 1, 2, 3, 4 };
            foreach (var element in collection) {
                Console.WriteLine(element);
            }
            Console.ReadKey();
        }
    }
}
