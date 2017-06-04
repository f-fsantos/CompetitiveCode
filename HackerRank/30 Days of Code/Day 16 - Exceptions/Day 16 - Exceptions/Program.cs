using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16___Exceptions {
    class Program {
        static void Main(string[] args) {
            string S = Console.ReadLine();
            int readNumber;
            try {
                readNumber = Int32.Parse(S);
                Console.WriteLine(readNumber);
            }
            catch(FormatException) {
                Console.WriteLine("Bad String");
            }
            
        }
    }
}
