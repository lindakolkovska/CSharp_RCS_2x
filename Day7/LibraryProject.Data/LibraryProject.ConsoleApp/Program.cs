using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryProject.Data;
using System.IO;

namespace LibraryProject.ConsoleApp
{
    class Program

    {
        private const string USER_ACTION = "(A - add a new book via Console, E - End work, S - Search, D - Delete a book, L - load book list, J - save to Jason)";

        static void Main(string[] args)
        {
            Library myFirstLibrary = new Library
            {
                Name = "Centrālā bibliotēka",
                Address = "Rūpniecības iela 32b"
            };

            myFirstLibrary.LoadBookList();
            //šis ir īsais variants myFirstLibrary.Name="Centrālā bibliotēka";

            //Console.WriteLine(myFirstLibrary.PrintInfo());

            var author1 = new Author()
            {
                Name = "Marks",
                Surname = "Tvens"
            };

            var book1 = new Book()
            {
                Title = "Toms Sojers",
                IsbnCode = "1"
                //Author = author1
            };
            book1.Author = author1;

            var book2 = new Book()
            {
                Title = "Toms Sojers 333",
                IsbnCode = "2"
                //Author = author1
            };
            book2.Author = author1;

            var author2 = new Author()
            {
                Name = "Imanuels",
                Surname = "Kants"
            };

            var book3 = new Book()
            {
                Title = "TPK",
                IsbnCode = "3",
                Author = author2
            };

            

            //pievienojam grāmatu
            bool addWasSucc = myFirstLibrary.AddBook(book1);
            bool addWasSucc1 = myFirstLibrary.AddBook(book2);
            bool addWasSucc2 = myFirstLibrary.AddBook(book3);

            #region oldapproach
            /*if (addWasSucc)
            {
                Console.WriteLine("Book added");
            }
            else
            {
                Console.WriteLine("Unable to add book");
            }*/

            /*string input = "jā";
            while (input == "jā" || input != "nē")
            {
                Console.WriteLine("Vai pievienot jaunu grāmatu?");
                input = Console.ReadLine();
                var choice = input.ToLower();

                if (choice == "nē")
                {
                    break;
                }
                else if (choice != "jā" && choice != "nē")
                {

                }



                var input1 = "";

                while (string.IsNullOrEmpty(input1))
                {
                    Console.WriteLine("Pievienojiet grāmatas nosaukumu: ");
                    input1 = Console.ReadLine();
                    var bookName = input1.Substring(0, 1).ToUpper() + input1.Substring(1).ToLower();

                    var input2 = "";

                    while(string.IsNullOrEmpty(input2))
                    {
                        Console.WriteLine("Pievienojiet grāmatas autora vārdu: ");
                        input2 = Console.ReadLine();

                        if (string.IsNullOrEmpty(input2))
                        {
                            Console.WriteLine("Autora vārds nav ievadīts");
                        }
                    }

                    var input3 = "";
                }
            }*/
            #endregion

            var showMenu = true;

            do
            {
                Console.WriteLine($"Ko darīsi? {USER_ACTION}");
                var userAction = Console.ReadLine();
                switch (userAction.ToUpper())
                {
                    case "A":
                        Console.WriteLine("Enter the title of the book: ");
                        var bookTitle = Console.ReadLine();

                        Console.WriteLine("Enter the author name of the book: ");
                        var authorName = Console.ReadLine();

                        Console.WriteLine("Enter the author surname of the book: ");
                        var authorLastName = Console.ReadLine();

                        Console.WriteLine("Enter the IsbnCode of the book: ");
                        var bookIsbn = Console.ReadLine();

                        var book = new Book()
                        {
                            Title = bookTitle,
                            IsbnCode = bookIsbn,
                            Author = new Author()
                            {
                                Name = authorName,
                                Surname = authorLastName
                            }

                        };

                        if (myFirstLibrary.AddBook(book))
                        {
                            Console.WriteLine("Book is added");
                        }
                        else
                        {
                            Console.WriteLine("Unable to add book");
                        }

                        //ĪSAIS PIERAKSTS Console.WriteLine(myFirstLibrary.AddBook(book) ? "Book is added": "Unable to add book");
                        break;
                    case "E":
                        showMenu = false;
                        break;
                    case "S":
                        Console.Write("Enter search criteria: ");
                        string searchCriteria = Console.ReadLine();

                        var results = myFirstLibrary.SearchBooks(searchCriteria);

                        if (results.Any())
                        {
                            foreach (var item in results)
                            {
                                Console.WriteLine(item.GetShortDescription());
                            }
                        }
                        else
                        {
                            Console.WriteLine("No books found");
                        }
                        break;
                    case "D":
                        Console.Write("Please choose a book to remove (by a book IsbnCode): ");
                        var isbnCodeInput = Console.ReadLine();

                        #region iwaskindawrong
                        //var bookToRemove = new Book()     //ŠITO NEVAJAG!!!!!
                        //{                                 //ŠITO NEVAJAG!!!!!
                        //    Title = input                 //ŠITO NEVAJAG!!!!!
                        //};                                //ŠITO NEVAJAG!!!!!


                        /*if (searchedBookToRemove.Any())
                        {
                            foreach (var item in searchedBookToRemove)
                            {
                                Console.WriteLine(item.GetShortDescription());
                            }
                        }
                        else
                        {
                            Console.WriteLine("No books found");
                        }*/
                        #endregion

                        if (myFirstLibrary.RemoveBook(isbnCodeInput))
                        {
                            
                            //Console.WriteLine($"{}");
                            Console.WriteLine($"Book is removed");
                        }
                        else
                        {
                            Console.WriteLine("Unable to remove book");
                        }

                        break;
                    case "J":
                        myFirstLibrary.SaveBooks();
                        break;
                    default:
                        Console.WriteLine($"Nav tādas darbības, atļautās darbības ir {USER_ACTION}");
                        break;
                }
            }
            while (showMenu);
        }
    }
}
