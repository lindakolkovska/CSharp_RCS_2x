using NameHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExtractedToAntoherFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new[] { "Hanna", "Trudy", "Steve" };
            //NamePrintingHelper.Printer(names);
            Console.WriteLine(NameFormatting.GetShortName("John", "Doe"));

            Console.ReadLine();
        }
    }
}
