using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {  /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }*/

            var name = "Linda8";
            var letterCounter = 0;
            for (int i = 0; i < name.Length; i++)
            {
                var ch = name.Substring(i, 1);
                //char isLetter = char.Parse(ch); --- KĻŪDAINA PĀRNESE NO char.IsLetter(Convert.ToChar(ch)) --- TAS NAV VIENS UN TAS PATS!!!
                
                if(char.IsLetter(Convert.ToChar(ch)))
                {
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
            }*/

            /*int[] numbers = new[] { 1, 3, 4, 56, 6, 9 };
            string[] names = new[] { "Linda", "Anna", "Gana" };
            int[] numbers2 = new int[6];
            numbers2[0] = 1;
            numbers2[1] = 3;
            numbers2[2] = 4;
            numbers2[3] = 56;
            numbers2[4] = 6;
            numbers2[5] = 9;

            var sum = 0;
            foreach (var number in numbers)     // tas 'var number' ir nodefinēts jauns mainīgais (whatever the name is) un 'in' piekabina masīva nosaukumu;
           {
                sum += number;
           }
            Console.WriteLine("Pirmā summa: " + sum);
            
            sum = 0;
            for (var i = 0; i < numbers.Length; i++)
             {
                 sum = sum + numbers[i];
             }
            Console.WriteLine("Otrā summa ir: " + sum);

            var sumIs = numbers.Sum();                      //!!!!!!!!!!
            Console.WriteLine("Trešā summa ir: " + sumIs);

            var maxValue = numbers.Max();
            Console.WriteLine(maxValue);

            int maxV = 0;
            for (var i = 0; i < numbers.Length; i++)
            { 
                if (maxV < numbers[i])
                {
                    maxV = numbers[i];
                }
                
            }
            Console.WriteLine("(1)Maksimālā vērtība ir: " + maxV);

            maxV = 0;
            foreach (var value in numbers)
            {
                if (maxV < value)
                {
                    maxV = value;
                }
            }

            Console.WriteLine("(2)Maksimālā vērtība ir: " + maxV);*/

            Console.ReadLine();
        }
    }
}
