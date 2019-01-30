using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopFindItem
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Ievadiet tekstu: ");
            string input = Console.ReadLine();

            Console.Write("Ievadiet, cik reizes vēlaties šo tekstu izdrukāt: ");
            string input1 = Console.ReadLine();
            int duplicate = Convert.ToInt16(input1);

            for (var i = 0; i < duplicate; i++)
            {
                Console.WriteLine(input);
            }*/

            /*string[] myStringArray = { "anna", "panna", "kanna", "ziema", "trase", "kanna" };

            //LINQ VERSIJA
            string searchString = "kanna";
            var itemFound = myStringArray.FirstOrDefault(n => n == searchString);
            if(itemFound != null)
            {
                Console.WriteLine(Array.IndexOf(myStringArray, searchString));
            }

            var foundItems = myStringArray.Where(n => n == searchString).ToArray();
            //--LINQ VERSIJA

            /*for (var i = 0; i < myStringArray.Length; i++)
            {
                string name = "kanna";
                if (name == myStringArray[i])
                {
                    Console.WriteLine($"Vārds {name} atrodas masīva {i}. pozīcijā");
                   //for cikls iziet cauri visiem masīva lielumiem un iedod 2 atbildes. Ja ir BREAK pielikts klāt, tad 
                }
            }*/

            /*Random rnd = new Random();
            double[] numbers = new double[10];

            for (var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 10);
                Console.WriteLine(numbers[i]);
            }
            //foreach (var x in numbers)
            //{
            //    if (x > 5)
            //  {
            //        Console.WriteLine(x);
            //   }
            //}*/

            //LINQ VERSIJA-----------
            /*var grThan5 = numbers.Where(n => n > 5).ToArray();
            foreach (var x in grThan5)
            {
                Console.WriteLine(x);
            }*/
            //LINQ VERSIJA----------

            string[] myStringArray = { "anna", "panna", "kanna", "ziema", "trase", "kanna" };

            foreach(var name in myStringArray)
            {
                if (name != "panna")
                {
                    continue;
                }
                
                foreach (var ch in myStringArray)
                {
                    Console.Write(ch);
                }
            }



            Console.ReadLine();
        }
    }
}
