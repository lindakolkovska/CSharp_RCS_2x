using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            //masīvs, kam nav predefinēts apjoms
            // vēl līdzīgi masīviem un sarakstiem ir hash, dictionary



            int[] numbers = new int[] {1,3,5,6,8,9};
            //int numbersGreaterThan5Count = 0;

            //List<int> numbersGreaterThat = new List<int>();
            var numberGreaterThan5 = numbers.Where(x => x > 5 && x < 9);
            


            /*foreach (var number in numbers)
            {
                if (number > 5)
                {
                    numbersGreaterThat.Add(number);
                }
            }*/

            /*int[] newNumbers = new int[numbersGreaterThan5Count];
            int j = 0;
            
            for (int i=0; i < numbers.Length; i++)
            {
                if (numbers[i] > 5)
                {
                    newNumbers[j] = numbers[i];
                    ++j;
                }
            }*/

            foreach (var newNumber in numberGreaterThan5)
            {
                Console.WriteLine(newNumber);
            }

            Console.ReadLine();
        }
    }
}
