using System.Drawing;
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
            #region Write a method bool TryGetPrice(string title, out double price) that returns true and sets price to 25.5 if title is "Clean Code", otherwise returns false and sets price to 0.Call it and print the price if found Write a method PrintBookInfo(string title, int pages = 300) where pages is optional. Call it once with only a title, and once passing both a title and pages.

            if (TryGetPrice("Clean Code", out double price))
            {
                Console.WriteLine($"Price: {price}");
            }

          
            PrintBookInfo("Clean Code");

            
            PrintBookInfo("Design Patterns", 500);
            #endregion

        }

        static bool TryGetPrice(string title, out double price)
        {
            if (title == "Clean Code")
            {
                price = 25.5;
                return true;
            }

            price = 0;
            return false;
        }

        static void PrintBookInfo(string title, int pages = 300)
        {
            Console.WriteLine($"Title: {title}, Pages: {pages}");
        }


    }
}