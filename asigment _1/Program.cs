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
            #region Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            int fictionVal = (int)Genre.Fiction;
            int nonFictionVal = (int)Genre.NonFiction;
            int scienceVal = (int)Genre.Science;

            Console.WriteLine($"Fiction int value: {fictionVal}");
            Console.WriteLine($"NonFiction int value: {nonFictionVal}");
            Console.WriteLine($"Science int value: {scienceVal}");
            #endregion

        }

       

        enum Genre
        {
            Fiction,
            NonFiction,
            Science
        }
    }
}