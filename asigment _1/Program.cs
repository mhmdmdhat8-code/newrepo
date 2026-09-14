using System.Drawing;
using System.Runtime.InteropServices;
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
            #region Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with "Clean Code".
            PrintBookTitle("Clean Code");
            #endregion

        }
        static void PrintBookTitle(string title)
        {
            Console.WriteLine("Book title: " + title);
        }
    }

    }  
