using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string time = Console.ReadLine();
        string result = TimeConverter(time);
        Console.WriteLine(result);
    }
    static string TimeConverter(string time) {
        string result;
        string timeOfDay = time.Substring(time.Length - 2, 2);
        string currentTime = time.Substring(0, time.Length - 2);
        string hours = currentTime.Substring(0, 2);

        if (timeOfDay == "AM") {
            if (hours == "12") {
                hours = "00";
            }
        }
        else {
            if (hours == "12")
                hours = "12";
            else
                hours = (Int32.Parse(hours) + 12).ToString();
        }
        result = hours + currentTime.Substring(2);
        return result;
    }
}
