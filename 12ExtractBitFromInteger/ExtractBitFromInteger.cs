using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main()
        {
            Console.Write("Please, enter a number:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please, enter position:");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine((n >> p) & 1);
        }
    }
}
