using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new[] { "anna", "zintis", "salvis" };
            int[] values = new[] { 1, 4, 9, 7 };

            //PrintArrayValues(names);

            //PrintArrayValues(new int[] { 1, 4, 9, 7 });

            //Console.WriteLine($"Maksimālā vērtībā ir {MaxValue(values)}");


            PrintName();
            PrintName("John");
            PrintName(string.Empty, "Doe"); // vai ("", "Doe") // vai PrintName(surname: "Doe")
            PrintName("Jane", "Doe"); // lai nojauktu secību PrintName(surname: "Doe", name: "Jane" );

            Console.ReadLine();
        }

        static void PrintArrayValues(string[] arrayOfStrings)
        {
            foreach (var str in arrayOfStrings)
            {
                Console.WriteLine(str);
            }
        }

        static void PrintArrayValues(int[] arrayOfIntegers)
        {
            foreach (var str in arrayOfIntegers)
            {
                Console.WriteLine(str);
            }
        }

        static int MaxValue (int[] values)
        {
            return values.Max();
        }

        static void PrintName (string name="", string surname="")
        {
            if(!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname))
            {
                Console.WriteLine($"{name} {surname}");
            }
            else if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine(name);
            }
            else if (!string.IsNullOrEmpty(surname))
            {
                Console.WriteLine(surname);
            }
            else
            {
                Console.WriteLine("Abi parametri tukši");
            }
        }
    }
}
