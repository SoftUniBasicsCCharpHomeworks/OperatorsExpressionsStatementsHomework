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
            StringBuilder encriptedMessage = new StringBuilder();
            bool isEmpty = false;
            bool isStart = false;
            int count = 0;

            Dictionary<char, char> specialChar = new Dictionary<char, char>();
            specialChar.Add('+', ' ');
            specialChar.Add('%', ',');
            specialChar.Add('&', '.');
            specialChar.Add('#', '?');
            specialChar.Add('$', '!');

            string command = Console.ReadLine();

            while (true)
            {
                if (command == "START" || command == "start")
                {
                    isStart = true;
                    command = Console.ReadLine();
                }
                if (command == "END" || command == "end")
                {
                    break;
                }
                if (string.IsNullOrEmpty(command))
                {
                    isEmpty = true;
                }
                if (isStart && isEmpty == false)
                {
                    count++;
                    command = specialChar.Aggregate(command, (result, s) => result.Replace(s.Key, s.Value));

                    for (int i = command.Length - 1; i >= 0; i--)
                    {
                        if ((command[i] >= 'A' && command[i] <= 'M') || (command[i] >= 'a' && command[i] <= 'm'))
                        {
                            encriptedMessage.Append((char)(command[i] + 13));
                        }
                        else if ((command[i] >= 'N' && command[i] <= 'Z') || (command[i] >= 'n' && command[i] <= 'z'))
                        {
                            encriptedMessage.Append((char)(command[i] - 13));
                        }
                        else
                        {
                            encriptedMessage.Append(command[i]);
                        }
                    }
                    encriptedMessage.AppendLine();
                }
                command = Console.ReadLine();
                isEmpty = false;
            }
            if (count == 0)
            {
                Console.WriteLine("No message received.");
            }
            else
            {
                Console.WriteLine("Total number of messages: {0}", count);
                encriptedMessage.ToString();
                for (int i = 0; i < encriptedMessage.Length; i++)
                {
                    Console.Write(encriptedMessage[i]);
                }
            }
        }
    }
}
