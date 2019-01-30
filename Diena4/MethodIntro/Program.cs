using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = GetUserInput();
            var y = GetUserInput();
            Console.ReadLine();
        }

        static void Print()
        {
            Console.WriteLine("oneone");
        }

        static int GetUserInput()
        {
            Console.WriteLine("Ievadi skaitli:");
            var userInput = Console.ReadLine();
            return int.Parse(userInput);
        }
    }
}
