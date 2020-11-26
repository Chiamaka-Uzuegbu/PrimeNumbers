using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Program shows the prime numbers between 1 and 1000");
            PrintPrimeNumbers();
            Console.ReadLine();
        }

        static void PrintPrimeNumbers()
        {
            bool primeNumber = true;
            for (int firstNum = 2; firstNum < 1000; firstNum++)
            {
                for (int j = 2; j < 1000; j++)
                {
                    if (firstNum % j == 0 && firstNum != j)
                    {
                        primeNumber = false;
                        break;
                    }
                }
                if (primeNumber)
                {
                    Console.Write($"\t{firstNum}");
                }
                primeNumber = true;
            }
        }
    }
}
