using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            Console.Write("Please, enter a number:");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please, enter position:");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Please, enter bit value:");
            int v = int.Parse(Console.ReadLine());

            int result = 0;

            if (v == 0)
            {
                result = n & ~(1 << p);
            }
            else
            {
                result = n | 1 << p;
            }
            Console.WriteLine(result);
        }
    }
}
