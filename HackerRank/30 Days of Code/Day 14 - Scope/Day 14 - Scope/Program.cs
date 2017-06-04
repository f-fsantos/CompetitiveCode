using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14___Scope {
    class Program {
        static void Main(string[] args) {
        }
    }
    class Difference {
        private int[] elements;
        public int maximumDifference;
        public Difference() {}
        public Difference(int[] arrayOfElements) {
            this.elements = arrayOfElements;
        }
        public void computeDifference() {
            maximumDifference = elements.Max() - elements.Min();
        }
    }
}
