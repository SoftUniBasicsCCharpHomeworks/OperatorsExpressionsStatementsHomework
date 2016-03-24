using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            uint mask = 7;

            uint firstBits = (n >> 3) & mask;
            uint secondBits = (n >> 24) & mask;

            n = n & ~(mask << 3);
            n = n & ~(mask << 24);
            n = n | (secondBits << 3);
            n = n | (firstBits << 24);
            Console.WriteLine(n);
        }
    }
}
