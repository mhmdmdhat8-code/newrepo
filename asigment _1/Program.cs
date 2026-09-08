using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using static System.Console;
namespace asigment__1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,Pages: 464" using the + operator.
            string title = "Clean Code ";
            int pages = 464;
            string sentence = "book: " + title + ", pages: " + pages;
            WriteLine(sentence);
            #endregion

        }
    }
}
