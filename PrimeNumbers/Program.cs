using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    /* Create a console application that prints all the prime numbers,
        starting from 1 to 100. Use a for loop for this purpose */
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 2; i <= 100; i++)
            {
                int isPrime = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime++;
                        if (isPrime == 2)
                        {
                            break;
                        }
                    }
                }
                if (isPrime != 2) 
                {
                    Console.WriteLine(i);
                }
                isPrime = 0;
            }
            Console.ReadLine();
        }
    }
}
