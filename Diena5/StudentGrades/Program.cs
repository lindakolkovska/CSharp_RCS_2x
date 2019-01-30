using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] jGrades = { 9, 7, 8, 6, 7 };
            int[] pGrades = { 7, 9, 6, 7, 5 };
            

            PrintGrades(jGrades, "Jānis");*/


            Dictionary<string, int[]> Grades = new Dictionary<string, int[]>();

            Grades.Add("Jāņa atzīmes", new[] { 9, 7, 8, 6, 7 });
            Grades.Add("Pētera atzīmes", new[] { 7, 9, 6, 7, 5 });

            Console.WriteLine("Ievadiet studenta vārdu: ");
            string input = Console.ReadLine();
            string studentName = input.ToLower();

            /*foreach (var grade in Grades)
            {
                Console.WriteLine(grade.Key);
                foreach (var item in grade.Value)
                {
                    Console.WriteLine(item);
                }
            }*/

            if(Grades.Keys)

            switch (studentName)
            {
                case "jānis":

                    Console.WriteLine();
                    break;
                case "pēteris":
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Nav studenta ar šādu vārdu.");
                    break;
            }

            Console.ReadLine();
        }

        static void PrintGrades(int[] grades, string name = "")
        {
            Console.WriteLine(name);
            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        static void smth(int[] grades, string name, string address, string postalAddress, string id = "")
        {

            Console.WriteLine(name);
        }
    }
}

