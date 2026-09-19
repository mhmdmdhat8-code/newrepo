using Microsoft.VisualBasic;
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
            #region Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to attempt the conversion.Print "Unknown genre" if it fails.
            string genreText = "Mystery";
            if (Enum.TryParse(genreText, out Genre resultGenre))
            {
                WriteLine($"Genre found: {resultGenre}");
            }
            else
            {
                // عند فشل التحويل (لأن Mystery غير موجودة في الـ Enum)
                WriteLine("Unknown genre");
            }
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