using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameHelper
{
    public class NameFormatting
    {
        public static string GetShortName(string name, string surname)
        {
            string formatedName = "";
            if(!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname))
            {
                formatedName = $"{name.Substring(0, 1).ToUpper()}.{surname.Substring(0,1).ToUpper() +surname.Substring(1).ToLower()}";
            }
            else if (!string.IsNullOrEmpty(name))
            {
                formatedName = name.Substring(0,1).ToUpper() + name.Substring(1).ToLower();
            }
            else if(!string.IsNullOrEmpty(surname))
            {
                formatedName = surname.Substring(0, 1).ToUpper() + surname.Substring(1).ToLower();
            }
            else
            {
                formatedName = "Nav ievadīts";
            }

            return formatedName;
        }
    }
}
