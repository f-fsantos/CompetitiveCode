using System;
using System.Collections.Generic;

namespace PrimePalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int primepal = 2;
            int n = 0;
            bool ispal = true;
            int prime = 0;
            bool isprime = true;
            int fd, sd;
            while (primepal < 1000)
            {
                n = (int)Math.Log10(primepal) + 1;
                if (n % 2 == 0)
                {
                    for (int i = 0; i < n / 2; i++)
                    {
                        fd = Convert.ToInt32(primepal.ToString()[i].ToString());
                        sd = Convert.ToInt32(primepal.ToString()[n - i-1].ToString());
                        if (fd != sd)
                        {
                            ispal = false;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < Math.Floor((double)n/2);i++)
                    {
                        fd = Convert.ToInt32(primepal.ToString()[i].ToString());
                        sd = Convert.ToInt32(primepal.ToString()[n - i-1].ToString());
                        if (fd != sd)
                        {
                            ispal = false;
                        }
                    }
                }
                if (ispal)
                {
                    for (int i = 2; i < primepal; i++)
                    {
                        if (primepal % i == 0)
                        {
                            isprime = false;
                            break;
                        }
                    }
                    if (ispal && isprime)
                    {
                        prime = primepal;
                    }
                }
                primepal++;
                isprime = true;
                ispal = true;
            }
            Console.WriteLine(prime);
        }
    }
}
