using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanUpTheWords {
    class Program {
        static void Main(string[] args) {
            string s = Console.ReadLine();
            string result = Regex.Replace(s, "[^a-zA-Z]", " ");
            result = Regex.Replace(result, @"\s+", " ");
            Console.WriteLine(result.Trim().ToLower());
        }
    }
}
