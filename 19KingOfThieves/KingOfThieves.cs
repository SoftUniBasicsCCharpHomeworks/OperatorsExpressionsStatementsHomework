using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfThieves
{
    class KingOfThieves
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char ch = (char)Console.Read();
            int p = 1;
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', n/2-i), new string(ch, p));
                p += 2;
            }
            Console.WriteLine("{0}",new string(ch,n));
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-',i), new string(ch, n-2*i));

            }
        }
    }
}
