using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevums1
{
    class Program
    {
        static void Main(string[] args)
        {

            int overspeed = 15;
            int penaltyPoints = 1;

            if (overspeed <= 0)
            {
                Console.Write("Ātrums nav pārkāpts");
            }
            else if (overspeed > 0 && overspeed <= 10)
            {
                if (penaltyPoints <= 0)
                {
                    Console.Write("Par ātruma pārkāpumu piemērojamais soda veids - rājiens");
                }
                else if (penaltyPoints == 1)
                {
                    Console.Write("Par ātruma pārkāpumu piemērojamais sods: 10.00Eur");
                }
                else
                {
                    Console.Write("Par ātruma pārkāpumu piemērojamais sods: 20.00Eur");
                }
                
            }
            else if (overspeed > 10 && overspeed <= 20)
            {
                if (penaltyPoints <= 0)
                {
                    Console.Write("Par ātruma pārkāpumu piemērojamais soda veids - 10.00");
                }
                else if (penaltyPoints == 1)
                {
                    Console.Write("Par ātruma pārkāpumu piemērojamais sods: 20.00Eur");
                }
                else
                {
                    Console.Write("Par ātruma pārkāpumu piemērojamais sods: 30.00Eur");
                }
            }
            else if (overspeed > 20 && overspeed <= 30)
            {
                Console.Write("Par ātruma pārkāpumu piemērojamais sods: 50.00Eur");
            }
            else if (overspeed > 30 && overspeed <= 40)
            {
                Console.Write("Par ātruma pārkāpumu piemērojamais sods: 100.00Eur");
            }
            else if (overspeed > 40 && overspeed <= 50)
            {
                Console.Write("Par ātruma pārkāpumu piemērojamais sods: 300.00Eur");
            }
            else
            {
                Console.Write("Par ātruma pārkāpumu piemērojamais soda veids -  autovadītāja tiesību atņemšana");
            }

            Console.ReadLine();
        }
    }
}
