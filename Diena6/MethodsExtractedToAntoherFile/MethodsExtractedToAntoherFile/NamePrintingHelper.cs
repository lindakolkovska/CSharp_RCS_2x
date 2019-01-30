using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExtractedToAntoherFile
{
    class NamePrintingHelper
    {
        public static void Printer(string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            
        }
    }
}
