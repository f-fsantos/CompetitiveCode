using System;
using System.Linq;
namespace _771.Jewels_And_Stones
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        // runtime: 88ms - faster than 87.24%
        public static int numJewelsInStonesForEach(string J, string S) 
        {
            int counter = 0;
            foreach(char letter in S)
            {
                if(J.Contains(letter))
                counter++;
            }
            return counter;
        }
        
        // runtime: 104ms - faster than 26.07% 
        public static int JewelsInStonesLinq(string J, string S)
        {
            return S.Where(x => J.Contains(x)).Count();
        }

        // runtime: 84ms - faster than 96.44%
        public static int JewelsInStonesFor(string J, string S){
            int counter = 0;

            for (int i = 0; i < S.Length; i++)
            {
                for(int k = 0; k < J.Length; k++)
                { 
                    if(S[i] == J[k]) 
                    {
                        counter++;
                    } // no brackets - extra 4ms on execution - god bless branch optimization
                }
                
            }
            return counter;
        }
    }
}
