using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_for
{
    class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }*/

            var name = "Linda";
            var letterCounter = 0;
            for (int i=0; i < name.Length; i++)
            {
                var ch = name.Substring(i, 1);

                if (char.IsLetter(Convert.ToChar(ch))) {
                    //letterCounter = letterCounter + 1;
                    ++letterCounter;
                    //letterCounter += 1;
                }

                Console.WriteLine($"{i} = {ch}");

            }

            if (letterCounter == name.Length)
            {
                Console.WriteLine("Visi ir burti");
            }
            else
            {
                Console.WriteLine("Visi nav burti");
            }


            /*foreach (var ch in name)
            {
                Console.WriteLine(ch);
            }

            Console.ReadLine();*/
        }
    }
}
