using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = new[] { 1, 3, 4, 56, 6, 9 };
            int i = 0;
            while (i < numbers.Length)
            {
                //Console.WriteLine(i + ":" + numbers[i]);
                Console.WriteLine($"{i} : {numbers[i]}");
                i++;
            }

            i = 0;
            do
            {
                Console.WriteLine("okay");
                i++;
            }
            while (i < numbers.Length);*/


            int value = 0;

            /*while (value < 1 || value > 20)
            {
                Console.Write("Ievadiet skaitli no 1 līdz 20: ");
                string input = Console.ReadLine();
                value = int.Parse(input);
                if (value < 1 || value > 20)
                {
                    Console.WriteLine("Ievadītā vērtība nav pareiza.");
                }
            }*/

            bool isInputValid = true;

            do
            {
                Console.Write("Ievadiet skaitli no 1 līdz 20: ");
                string input = Console.ReadLine();
                value = int.Parse(input);
                if (value < 1 || value > 20)
                {
                    Console.WriteLine("Ievadītā vērtība nav pareiza.");
                    isInputValid = false;
                } else
                {
                    Console.WriteLine($"Ievadītā skaitļa vērtība ir {value}");
                    
                }
            }
            while (!isInputValid);


            Console.ReadLine();
        }
    }
}
