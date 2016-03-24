using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitExchangeAdv
{
    class Program
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            uint mask = 1;
            for (int i = p; i <= p+k-1; i++)
            {
                uint bitQ = (n >> q) & mask;
                uint bitP = (n >> i) & mask;
                n = n & ~(mask << i);
                n = n & ~(mask << q);
                n = n | (bitP << q);
                n = n | (bitQ << i);
                q++;
            }
            Console.WriteLine(n);
        }
    }
}
