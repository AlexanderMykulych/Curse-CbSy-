using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2 {
    public class User {
        public DateTime Birthday { get; set; }
        public string Name { get; set; }
        public override string ToString() {
            return string.Format("Name = {0}, Birthday = {1}", Name, Birthday);
        }
    }
}
