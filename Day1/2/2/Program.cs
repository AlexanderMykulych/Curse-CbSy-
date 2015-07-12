using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2 {
    public class Program {
        static void Main(string[] args) {
            MEnumerable collection = new MEnumerable();
            var elem1 = new Element(new User(){Name ="qwerty", Birthday = DateTime.UtcNow.AddYears(-20)});
            elem1.Add(new Element(new User() { Name = "asddd", Birthday = DateTime.UtcNow.AddYears(-6) }));
            elem1.Add(new Element(new User() { Name = "zxczxc", Birthday = DateTime.UtcNow.AddYears(-5) }));
            elem1.Add(new Element(new User() { Name = "jgjfjdl", Birthday = DateTime.UtcNow.AddYears(-2) }));
            elem1.Add(new Element(new User() { Name = "mcmzxc", Birthday = DateTime.UtcNow.AddYears(-1) }));
            var elem2 = new Element(new User() { Name = "123123", Birthday = DateTime.UtcNow.AddYears(-22) });
            elem2.Add(new Element(new User() { Name = "23465", Birthday = DateTime.UtcNow.AddYears(-1) }));
            collection.Add(elem1);
            collection.Add(elem2);
            foreach (var elem in collection) {
                Console.WriteLine(elem.User);
            }
            Console.ReadKey();
        }
    }
}
