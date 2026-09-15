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
            #region Write a method PrintAllTitles(params string[] titles) that prints each title on its own line. Call it with three book titles.
            PrintAllTitles("Clean Code", "Design Patterns", "C# in Depth");
            #endregion

        }

        static void PrintAllTitles(params string[] titles)
        {
            
            foreach (string title in titles)
            {
                Console.WriteLine(title);
            }
        }


    }
}