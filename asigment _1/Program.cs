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
            #region Write a do-while loop that prints "Checking book..." exactly 3 times.
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }
            #endregion
        }
    }
}
