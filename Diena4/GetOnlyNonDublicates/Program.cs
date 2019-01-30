using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetOnlyNonDublicates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] newArray = { "ABC", "CDE", "FGA", "CDE", "GAE", "ABC", "ABO" };

            //LINQ
            /*
            var duplicate = newArray.GroupBy(x => x).Where(y => y.Count() > 1).Select(y => y.Key);

            foreach (var z in duplicate)
            {
                Console.WriteLine(z);
            }
            //CITS LINQ VARIANTS
            (var uniqueNames = names.DIstinct().ToArray();)

            foreach( var un in newArray.Distinct())
            {
            Console.WriteLine(un);
            }
             */

            int x = 0;
            for (int i = 0; i < newArray.Length; i++)
            {
                for (int j = 0; j < newArray.Length; j++)
                {
                    if (newArray[i] == newArray[j] && i!= j)
                    {
                        newArray[j] = "";
                    }
                }

            }

            var nonEmptyCount = 0;
            foreach (var duplicate in newArray)
            {
                if(!string.IsNullOrEmpty(duplicate))
                {
                    ++nonEmptyCount;
                }
            }

            string[] newArray2 = new string[nonEmptyCount];


            foreach (var name in newArray)
            {
                if (!string.IsNullOrEmpty(name)){
                    newArray2[x] = name;
                    x++;
                }
                
            }


            Console.ReadLine();
        }
    }
}
