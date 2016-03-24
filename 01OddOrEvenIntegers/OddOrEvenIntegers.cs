using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main()
        {
            Console.Write("Please, enter a number:");
            int n = int.Parse(Console.ReadLine());
            bool isOdd = false;
            if (n % 2 != 0)
            {
                isOdd = true;
            }
            Console.WriteLine(isOdd);
            
        }
    }
}
