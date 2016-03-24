using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBit
{
    class ExtractBit
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int thirdPosition = (n >> 3) & 1;
            Console.WriteLine(thirdPosition);
        }
    }
}
