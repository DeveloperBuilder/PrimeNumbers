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
            bool isPrime = true;
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (j % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
                isPrime = true;
            }
            Console.ReadLine();
        }
    }
}
