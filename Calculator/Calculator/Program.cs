using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ievadiet 1.skaitli: ");
            var number1 = Console.ReadLine();
            Console.Write("Ievadiet 2.skaitli: ");
            var number2 = Console.ReadLine();
            Console.WriteLine("Ievadiet vēlamo darbību (+,-,*,/)");
            var operation = Console.ReadLine();
            double one = int.Parse(number1);
            double two = int.Parse(number2);
            
            switch (operation)
            {
                case "+":
                    Console.WriteLine(one + two);
                    break;
                case "-":
                    Console.WriteLine(one - two);
                    break;
                case "*":
                    Console.WriteLine(one * two);
                    break;
                case "/":
                    Console.WriteLine(one / two);
                    break;
                default:
                    Console.WriteLine("Ievadītā darbība nav pareiza");
                    break;
            }

            Console.ReadLine();

        }
    }
}
