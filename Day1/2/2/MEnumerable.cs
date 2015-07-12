using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2 {
    public class MEnumerable : IEnumerable<Element>, IEnumerator<Element> {
        private Element _current { get; set; }
        private List<Element> Firsts { get; set; }
        private List<Element> Nodes { get; set; }
        public MEnumerable() {
            Firsts = new List<Element>();
            Nodes = new List<Element>();
        }
        public IEnumerator<Element> GetEnumerator() {
            List<Element> queue = new List<Element>(Nodes);
            while (queue.Any()) {
                var newQueue = new List<Element>();
                foreach (var elem in queue) {
                    newQueue.AddRange(elem.Childrens);
                    yield return elem;
                }
                queue = newQueue;
            }            
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }

        public Element Current {
            get { return _current; }
        }

        public void Dispose() {
            this.Reset();
        }

        object System.Collections.IEnumerator.Current {
            get { return this.Current; }
        }

        public bool MoveNext() {
            _current = _current.Childrens != null ? _current.Childrens.First() : null;
            return _current != null;
        }

        public void Reset() {
            Nodes = Firsts;
        }
        public void Add(Element elem) {
            Nodes.Add(elem);
        }
    }
}
