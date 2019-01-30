using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Data;


namespace WorkWithStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student.Data.Student
            {
                Name = "John",
                Surname = "Doe",
                Grades = new List<int>() { 1, 5, 6, 7, 8, 9 }
            };

            Console.WriteLine(student1.Name);
            Console.WriteLine($"Stdenta {student1.GetShortName()} vidējā atzīme ir {student1.GetAverageGrade()}");

            var student2 = new Student.Data.Student
            {
            Name = "Jānis",
            Surname = "Berzs",
            Grades = new List<int>() { 5, 6, 7, 8, 4, 3 }
            };



            //Console.WriteLine(student2.Name);

            Console.ReadLine();
        }
    }
}
