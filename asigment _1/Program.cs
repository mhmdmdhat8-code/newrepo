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
            #region Using the same books array, loop through it and print each title, but stop completely (break) once you reach "Refactoring".
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }
                WriteLine(book);

            }
            #endregion

        }
    }
}
