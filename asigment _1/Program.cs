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
            #region Build the same sentence as above, but using string interpolation ($"...").
            string title = "Clean Code ";
            int pages = 464;
            string interpolation = $"book: {title} , pages: {pages}";
            WriteLine(interpolation);
            #endregion

        }
    }
}
