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
            #region Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };, use a for loop to print each book with its position number, like 1.Clean Code.
            string[] book = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < book.Length; i++)
            {
                WriteLine(book[i]);
            }
            #endregion
        }
    }
}
