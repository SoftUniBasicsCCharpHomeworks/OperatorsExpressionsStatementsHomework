using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitsAtCrossroads
{
    class BitsAtCrossroads
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            uint[] numbers = new uint[n];
            string command = Console.ReadLine();
            
            int count = 0;
            uint bit = 0;

            while (command != "end")
            {
                var position = command.Split(' ').Select(int.Parse).ToArray();
                int row = position[0];
                int col = position[1];

                for (int i = 0; i < n; i++)
                {
                    uint mask = 1;
                    if ((row + col) - i >= 0 && (row + col) - i < n)
                    {
                        bit = (numbers[i] >> ((row + col) - i)) & 1;
                        if ( bit== 1)
                        {
                            count++;
                        }
                        numbers[i] = numbers[i] | (mask << ((row + col) - i)); 
                    }
                    if (((col - row) + i) >= 0 && ((col - row) + i) < n)
                    {
                        bit = (numbers[i] >> ((col - row) + i)) & 1;
                        if (bit == 1)
                        {
                            count++;
                        }
                        numbers[i] = numbers[i] | (mask << ((col - row) + i));
                    }
                }
                command = Console.ReadLine();

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine(count);
        }
    }
}
