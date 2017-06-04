using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8___DictionariesAndMaps {
    class Program {
        static void Main(string[] args) {
            int n = Int32.Parse(Console.ReadLine());
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            for (int i = 0; i < n; i++){
                string inputPhone = Console.ReadLine();
                phoneBook.Add(inputPhone.Split(' ')[0], inputPhone.Split(' ')[1]);
            }
            string input;
            while((input = Console.ReadLine()) != "") { // null when executed against HackerRank's test system
                if(phoneBook.ContainsKey(input)) {
                    Console.WriteLine($"{input}={phoneBook[input]}");
                }
                else {
                    Console.WriteLine("Not found");
                }
            }
        }
    }
}
