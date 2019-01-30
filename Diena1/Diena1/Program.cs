using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 1;
            //double d = Double.MaxValue;
            //string y = "Linda";

            /*int x = 1;
            Console.WriteLine(x);
            x = 2;
            Console.WriteLine(x);

            int y = 5;
            x = 3 + y;
            Console.WriteLine(x);

            int z;

            var a = 1;

            DateTime today = DateTime.Now;
            Console.WriteLine(today);*/

            /*int x = 4;
            int y;

            if (x > 0)
            {
                y = 7;
                Console.WriteLine(x + " ir ielāks par 0");
            }
            else
            {
                y = 845;
                Console.WriteLine(x + "Mazāks par 0");
            };

            Console.WriteLine(y);*/

            Console.Write("Ievadiet vārdu: ");
            var name = Console.ReadLine();
            Console.Write("Ievadiet uzvārdu: ");
            var lastName = Console.ReadLine();

            Console.WriteLine(name + " " + lastName);
            //Console.WriteLine($"Mani sauc: {name} {lastName}");

            Console.ReadLine();
            
        }    
    }
}
