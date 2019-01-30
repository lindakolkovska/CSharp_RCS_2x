using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }
        public string IsbnCode { get; set; }

        public string GetShortDescription()
        {
            return $"Book title: {Title}, Author: {Author?.Name} {Author?.Surname}, IsbnCode: {IsbnCode}";
        }
    }
}
