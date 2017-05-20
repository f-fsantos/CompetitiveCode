using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2___Operators {
    class Program {
        static void Main(string[] args) {
            double mealCost = Double.Parse(Console.ReadLine());
            int tipPercent = Int32.Parse(Console.ReadLine());
            int taxPercent = Int32.Parse(Console.ReadLine());
            double tip = mealCost * tipPercent / 100;
            double tax = mealCost * taxPercent / 100;
            int totalCost = Convert.ToInt32(Math.Round(mealCost + tip + tax));
            Console.WriteLine("The total meal cost is {0} dollars.", totalCost);
        }
    }
}
