using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2__switch_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int valueToCheck = 10;

            switch (valueToCheck)
            {
                case 1:
                     Console.Write("ir 1");
                break;
                case 2:
                    Console.Write("ir 2");
                break;
                default:
                     Console.Write($"Vērtība ir {valueToCheck}");
                break;
            }

            Console.ReadLine();*/

            

            Console.Write("Lūdzu, ievadiet vārdu: ");
            string word = Console.ReadLine();
            string firstLetter = word.Substring(0, 1).ToLower();


            switch (firstLetter)
            {
                case "A":
                    Console.Write($"Vārds sākas ar burtu {firstLetter}");
                break;
                case "B":
                    Console.Write($"Vārds sākas ar burtu {firstLetter}");
                break;
                default:
                    Console.Write($"Vārds sākas ar citu burtu");
                break;
            }

            Console.ReadLine();
        }
    }
}
