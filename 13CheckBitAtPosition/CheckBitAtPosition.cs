using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBitAtPosition
{
    class CheckBitAtPosition
    {
        static void Main()
        {
            Console.Write("Please, enter a number:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please, enter position:");
            int p = int.Parse(Console.ReadLine());

            int bit = (n >> p) & 1;
            bool isOne = bit==1;

            Console.WriteLine(isOne);
        }
    }
}
