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
            #region Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            string title = "Refactoring";
            switch (title)
            {
                case "Clean Code":
                    WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    WriteLine("Nice pick!");
                    break;

                default:
                    WriteLine("Never heard of it");
                    break;
            }
            #endregion
        }
    }
}
