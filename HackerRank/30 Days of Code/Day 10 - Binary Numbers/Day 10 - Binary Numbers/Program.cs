using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10___Binary_Numbers {
    class Program {
        static void Main(string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            int maxStraight = 0, straight = 0;

            while(n != 0) {
                if (n % 2 == 1)
                    straight += 1;
                else {
                    if (straight >= maxStraight)
                        maxStraight = straight;
                    straight = 0;
                }
                n = (int)Math.Floor(n / (double)2);
            }
            if (straight >= maxStraight)
                maxStraight = straight;
            Console.WriteLine(maxStraight);

        }
    }
}
