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
            #region Add a private string password = "secret"; field to a Book class. Try to print it from Main (outside the class). What happens, and why?
            Book mybook =new Book();
            WriteLine(mybook.password);

            // what happend: لم يتم تشغيل البرنامج وظهر ايرور كومبيلر 
            // why: لتطبيق مبدأ  Encapsulation
            #endregion

        }

        class Book
        {
            public string Title = "Clean Code";
            private string password = "secret";
        }


    }
}