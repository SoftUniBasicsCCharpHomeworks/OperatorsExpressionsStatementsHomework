using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.Write("Please, enter a positive number:");
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (n == 0 || n == 1 || n < 0)
            {
                isPrime = false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i==0)
                {
                    isPrime = false;
                }
            }
            
            Console.WriteLine(isPrime);
        }
    }
}
