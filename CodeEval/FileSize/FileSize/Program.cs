using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSize {
    class Program {
        static void Main(string[] args) {
            long size = new System.IO.FileInfo(args[0]).Length;
            Console.WriteLine(size);
        }
    }
}
