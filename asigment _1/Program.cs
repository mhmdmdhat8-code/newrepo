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
            #region Build the same sentence again, but using string.Format().
            string title = "Clean Code";
            int pages = 464;
            string formattedSentence = string.Format("Book: {0}, Pages: {1}", title, pages);
            WriteLine(formattedSentence);
            #endregion
        }
    }
}
