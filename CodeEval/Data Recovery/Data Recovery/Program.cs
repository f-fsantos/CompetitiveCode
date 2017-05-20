using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Recovery {
    class Program {
        static void Main(string[] args) {

            string s = Console.ReadLine();
            string[] data = s.Split(';')[0].Split(' ');
            int[] order = s.Split(';')[1].Split(' ').Select(int.Parse).ToArray();
            string[] arranged = new String[data.Length];
            string sentence = "";
            for(int i = 0; i < order.Length; i++) {
                arranged[order[i] - 1] = data[i];
            }
            for (int i = 0; i < arranged.Length; i++) {
                if(arranged[i] == null) {
                    arranged[i] = data.Last();
                }
                sentence = sentence + arranged[i] + " ";
            }
            sentence = sentence.Trim();
            Console.WriteLine(sentence);
        }
    }
}
