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
            #region Given int genreNumber = 1;, cast it into a Genre value and print the result.
            int genrenum = 1;
            Genre selectedGenre = (Genre)genrenum;
            WriteLine($"The genre for number {genrenum} is: {selectedGenre}");
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