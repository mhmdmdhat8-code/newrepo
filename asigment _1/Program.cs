using System.Drawing;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using static System.Console;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace asigment__1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, assign it Genre.Science, and print it.
            Book myBook = new Book();

            myBook.Title = "Quantum Physics";
            myBook.BookGenre = Genre.Science;
            WriteLine($"Book: {myBook.Title}, Genre: {myBook.BookGenre}");
            #endregion

        }

        class Book
        {
            public string Title { get; set; }
            public Genre BookGenre { get; set; }

        }

        enum Genre
        {
            Fiction,
            NonFiction,
            Science
        }
    }
}