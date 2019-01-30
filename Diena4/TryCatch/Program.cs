using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                uint x = 0;
                Console.Write("Ievadi skaitli: ");
                string input = Console.ReadLine();
                x = uint.Parse(input);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex); //parasti log failā rādās paziņojumi;
            }
            finally // izpildas gan ja izdodas kods, gan ja neizdodas
            {
                Console.WriteLine("finally");
            }

            Console.ReadLine();
        }
    }
}
