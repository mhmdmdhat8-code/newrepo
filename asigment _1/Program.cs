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
            #region Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
            string genreText = "Science";
            Genre parsedGenre = (Genre)Enum.Parse(typeof(Genre), genreText);
            WriteLine($"Parsed Genre: {parsedGenre}");
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