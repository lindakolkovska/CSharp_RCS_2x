using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            //rekursīva f-ja - izsauc pati sevi.Neapskatīsim.
            //PrintName();
            var x = GetInt("Ievadi skaitli x: ");
            var y = GetInt("Ievadi skaitli y: ");

            var a = Add(x, y);
            var b = Substract(x, y);
            var c = Divide(x, y);
            var d = Multiply(x, y);

            Console.WriteLine("Izvēlēties darbību (+,-,/,*)");
            string input = Console.ReadLine();

            switch (input)
            {
                case "+":
                    Console.WriteLine($"Skaitļu summa ir {a}");
                    break;
                case "-":
                    Console.WriteLine($"Skaitļu starpība ir {b}");
                    break;
                case "/":
                    Console.WriteLine($"Skaitļu rezinājums ir {c}");
                    break;
                case "*":
                    Console.WriteLine($"Skaitļu dalījuma ir {d}");
                    break;
                default:
                    Console.WriteLine("Kļūdaini ievadīta darbība.");
                    break;
            }

            Console.ReadLine();
        }

        static void PrintName()
        {
            Console.Write("bla");
        }

        static int GetInt(string userPrompt)
        {
            int userInput;

            Console.Write(userPrompt);
            var input = Console.ReadLine();

            var result = int.TryParse(input, out userInput);

            if (!result)
            {
                Console.WriteLine("Nav ievadīts skaitlis");
                return 0;
            }

            return userInput;
        }

        //add substract divide multiply
        //visām metodēm jāsaņem 2 veseli skaitļi

        static int Add(int x, int y)
        {
            var sum = x + y;
            return x + y;
        }

        static int Substract(int x, int y)
        {
            var substr = x-y;
            return substr;
        }

        static double Divide(int x, int y)
        {
            var division = x/y;
            return division;
        }

        static int Multiply(int x, int y)
        {
            var multiply = x * y;
            return multiply;
        }

        /*        public int Papildus()
        {
            int masivaGarums2 = 0;
            try
            {
                Console.WriteLine("Ievadiet masiva garumu");
                String ievade = Console.ReadLine();
                masivaGarums2 = Convert.ToInt16(ievade);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Nepareiza ievade, masivam pieskirts garums 5");
                Console.WriteLine(ex.Message);

            }
            
            return masivaGarums2;*/
    }
}
