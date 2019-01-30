using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace LibraryProject.Data
{
    public class Library
    {
        private const string FILE_PATH = @"c:\temp\books.json";
        public string Address { get; set; }
        public string Name { get; set; }

        public IEnumerable<Book> Books
        {
            get { return _books.AsReadOnly(); }
        }


        private List<Book> _books = new List<Book>();

        

        public bool AddBook(Book book)
        {

            if (book != null
                && book.Author != null && !string.IsNullOrEmpty(book.Title)
                && !string.IsNullOrEmpty(book.Author.Name)
                && !string.IsNullOrEmpty(book.Author.Surname)
                && !string.IsNullOrEmpty(book.IsbnCode))
            {
                _books.Add(book);
                return true;
            }
            return false;
        }

        public IEnumerable<Book> SearchBooks(string searchQuery)
        {
            searchQuery = searchQuery.ToUpper();
            return _books.Where(book => book.Title.ToUpper().Contains(searchQuery) 
                                    || book.Author.Name.ToUpper().Contains(searchQuery) 
                                    || book.Author.Surname.ToUpper().Contains(searchQuery));
        }

        public bool RemoveBook(Book book)
        {
                return _books.Remove(book);            
        }

        public bool RemoveBook(string isbnCode)
        {
            if (!string.IsNullOrEmpty(isbnCode))
            {
                var bookForRemoval = _books.FirstOrDefault(book => book.IsbnCode.ToUpper() == isbnCode.ToUpper());
                if (bookForRemoval !=null)
                {
                    _books.Remove(bookForRemoval);
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            return false;
        }

        public string PrintInfo()
        {
            return $"{Name}, {Address}";
        }

        public void LoadBookList ()
        {
            if (File.Exists(FILE_PATH))
            {
                var jsdonData = File.ReadAllText(FILE_PATH);
                _books = JsonConvert.DeserializeObject<List<Book>>(jsdonData);
            }

        }

        public void SaveBooks()
        {
                // Convert Person list object to JOSN string format  
                string jsonData = JsonConvert.SerializeObject(_books);

                File.WriteAllText(FILE_PATH, jsonData);
        }

    }
}
