using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibraryProject.Data;

namespace LibraryProject.WindowsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Library myFirstLibrary = new Library();

        public MainWindow()
        {
            InitializeComponent();

            myFirstLibrary.Name = "First Library";
            myFirstLibrary.Address = "Some address 123";

            bookList.ItemsSource = myFirstLibrary.Books;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var book = new Book()
            {
                IsbnCode = txtIsbn.Text,
                Title = txtTitle.Text,
                Author = new Author()
                {
                    Name = txtAuthorName.Text,
                    Surname = txtAuthorSurname.Text
                }
            };

           if (myFirstLibrary.AddBook(book))
            {
                lblResult.Content = "Book added";
            }
           else
            {
                lblResult.Content = "Book not added";
            }
            bookList.ItemsSource = myFirstLibrary.Books;
        }
    }
}
