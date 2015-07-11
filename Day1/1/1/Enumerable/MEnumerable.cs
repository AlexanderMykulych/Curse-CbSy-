using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Enumerable {
    public class MEnumerable : IEnumerable<int>, IEnumerator<int> {

        private int position { get; set; }
        private int lastIndex { get; set; }
        private int[] elements { get; set; }
        public MEnumerable() {
            position = -1;
            lastIndex = -1;
            elements = new int[1];
        }
        public IEnumerator<int> GetEnumerator() {
            position = -1;
            while (true) {
                if (position < elements.Count() - 1) {
                    yield return elements[++position] * elements[position];
                } else {
                    yield break;
                }
            }
        }
        public int Current {
            get { return elements[position]; }
        }

        public void Dispose() {
            position = -1;
        }

        object System.Collections.IEnumerator.Current {
            get { throw new NotImplementedException(); }
        }

        public bool MoveNext() {
            position++;
            return true;
        }

        public void Reset() {
            throw new NotImplementedException();
        }
        public void Add(int element) {
            if (lastIndex < elements.Length-1) {
                elements[++lastIndex] = element;
                return;
            }
            var newArray = new int[elements.Length * 2];
            elements.CopyTo(newArray, 0);
            newArray[++lastIndex] = element;
            elements = newArray;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }
    }
}