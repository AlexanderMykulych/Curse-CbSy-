using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2 {
    public class Element {
        User _user { get; set; }
        public List<Element> Childrens { get; set; }
        public List<Element> Parents { get; set; }
        public Element Pair { get; set; }
        public Element(User user) {
            Childrens = new List<Element>();
            Parents = new List<Element>();
            _user = user;
        }
        public void Add(Element elem) {
            if (Childrens == null) {
                Childrens = new List<Element>();
            }
            Childrens.Add(elem);
        }
        public User User { get { return _user; } }
    }
}
