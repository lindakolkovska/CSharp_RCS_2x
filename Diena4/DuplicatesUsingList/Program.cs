using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatesUsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] newArray = { "ABC", "CDE", "FGA", "CDE", "GAE", "ABC", "ABO" };

            List<string> uniqueNameList = new List<string>();

            foreach (var names in newArray)
            {
                if(!uniqueNameList.Contains(names))
                {
                    uniqueNameList.Add(names);
                }
            }

            foreach (var name in uniqueNameList)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
