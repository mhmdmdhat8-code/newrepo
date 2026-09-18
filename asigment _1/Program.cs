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
            #region Add a public string Title; field to Book. Set it and print it from Main.
            Book mybook = new Book();
            mybook.Title = "Clean Code";
            WriteLine(mybook.Title);
            #endregion

        }

        class Book
        {
            public string Title;
            private string password = "secret";
            internal int copiesInStock = 5;
        }


    }
}