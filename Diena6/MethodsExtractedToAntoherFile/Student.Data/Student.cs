using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameHelper;

namespace Student.Data
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<int> Grades = new List<int>();

        public double GetAverageGrade()
        {
            return Grades.Average();
        }
        
        public string GetShortName()
        {
            return NameFormatting.GetShortName(Name, Surname);
        }
    }
}
