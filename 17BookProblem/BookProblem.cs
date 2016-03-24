using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProblem
{
    class BookProblem
    {
        static void Main()
        {
            decimal pages = decimal.Parse(Console.ReadLine());
            decimal campingDays = decimal.Parse(Console.ReadLine());
            decimal pagesPerDay = decimal.Parse(Console.ReadLine());

            decimal readingDays = 30 - campingDays;
            decimal x = readingDays * pagesPerDay;
            if (x==0)
            {
                Console.WriteLine("never");
                return;
            }

            decimal time = pages / x;
            decimal years = time / 12;
            decimal month = time % 12;

           

            Console.WriteLine("{0} years {1} months", Math.Truncate(years), Math.Ceiling(month));
        }
    }
}
