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
            #region Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object.Print the final result.
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Book List");
            stringBuilder.Append(" - Updated");
            WriteLine(stringBuilder);
            #endregion

        }
    }
}
