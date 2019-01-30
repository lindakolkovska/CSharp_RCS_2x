using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;

namespace WriteAndReadToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Teksta ierakstīšana
            /*var text = "Text to write";

            File.WriteAllText(@"C:\temp\test.txt", text);

            string[] lines = { "First line", "Second line", "Third line" };
            // WriteAllLines creates a file, writes a collection of strings to the file,
            // and then closes the file.  You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllLines(@"C:\temp\test.txt", lines);*/

            /*string text = System.IO.File.ReadAllText(@"C:\temp\test.txt");            //C:\temp\test.txt
            Console.WriteLine(text);*/
            #endregion

            var records = new List<Person>
            {
                new Person {Name = "Charles", Surname = "Cult"} ,
                new Person {Name = "Anna", Surname = "Bolt"},
            };

            using (var writer = new StreamWriter("C:\\temp\\csvsep.csv"))
            using (var csv = new CsvWriter(writer))
            {
                //csv.Configuration.Delimiter = ",";
                csv.WriteRecords(records);
            }

            using (var reader = new StreamReader(@"C:\temp\csvsep.csv"))
            using (var csv = new CsvReader(reader))
            {
                var rec = csv.GetRecords<Person>();
                foreach (var item in rec)
                {
                    Console.WriteLine(item.Name);
                }
                

            }
            Console.ReadLine();
        }
    }
}
