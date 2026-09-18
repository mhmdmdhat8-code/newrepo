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
            #region Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why?
                        Book mybook = new Book();
            WriteLine($"Copies in stock: {mybook.copiesInStock}");

            // does it compile? yes 
            // why: لأن كلمة internal بتسمح لك بالوصول للمتغير داخل المشروع الواحد 
            #endregion

        }

        class Book
        {
            public string Title = "Clean Code";
            private string password = "secret";
            internal int copiesInStock = 5;
        }


    }
}