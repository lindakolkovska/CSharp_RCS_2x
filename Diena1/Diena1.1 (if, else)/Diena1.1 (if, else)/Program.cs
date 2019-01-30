using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diena1._1__if__else_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100;

            if (x > 10)
            {
                Console.WriteLine($"{x} ir liekāks par 10");
            }
            else if (x >= 5 && x <= 10)
            {
                Console.WriteLine($"{x} ir no 5 līdz 10");
            }
            else
            {
                Console.WriteLine($"{x} ir mazāks vai vienāds ar 5");
            }

            // principā - ja ir 1 koda rinda, aiz if un else var nelikt {}, resp., vnk ir nākamā rinda. yeah, whatever


            //int y = (x > 10) ? 1 : 2;
            //Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}