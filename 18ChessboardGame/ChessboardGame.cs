using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessboardGame
{
    class ChessboardGame
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int black = 0;
            int white = 0;
            for (int i = 0; i < input.Length; i+=2)
            {
                if (i>n*n-1)
                {
                    break;
                }
                if ((input[i]>=48 && input[i]<=57) || (input[i]>=97 && input[i]<=122))
                {
                    black += input[i];
                }
                if (input[i] >= 65 && input[i] <= 90)
                {
                    white += input[i];
                }
            }
            for (int i = 1; i < input.Length; i += 2)
            {
                if (i > n * n-1)
                {
                    break;
                }
                if ((input[i] >= 48 && input[i] <= 57) || (input[i] >= 97 && input[i] <= 122))
                {
                    white += input[i];
                }
                if (input[i] >= 65 && input[i] <= 90)
                {
                     black+= input[i];
                }
            }
            if (black>white)
            {
                Console.WriteLine("The winner is: black team");
                Console.WriteLine(black-white);
            }
            if (black < white)
            {
                Console.WriteLine("The winner is: white team");
                Console.WriteLine(white - black);
            }
            if (black == white)
            {
                Console.WriteLine("Equal result: {0}", black);
            }
            
        }
    }
}
