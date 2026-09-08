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
            #region Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Book List");
            stringBuilder.Replace("Book List", "Library");
            WriteLine(stringBuilder.ToString());
            #endregion

        }
    }
}
