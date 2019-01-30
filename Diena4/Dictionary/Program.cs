using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.piemērs
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("GL", 1);
            dic.Add("AL", 2);
            //dic.Add("GL", 3); // neļauj ar vienu un to pašu atslēgu pievienot vēl kkadu elelmentu.

            //2.piemērs
            Dictionary<string, int[]> dic1 = new Dictionary<string, int[]>();

            int[] allGrades = new[] { 4, 6, 4, 9 };

            dic1.Add("GL", new[] { 1, 4, 5, 9 });
            dic1.Add("AP", allGrades);

            foreach (var item in dic1)
            {
                Console.WriteLine(item.Key);
                foreach (var grade in item.Value)
                {
                    Console.WriteLine(grade);
                }
            }

            Console.ReadLine();
        }
    }
}
