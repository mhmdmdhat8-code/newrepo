using System.Drawing;
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
            #region Rewrite the method from question 5 as AddBonusPagesByRef(ref int pages) using ref. Call it and print pages afterward. How is the result different from question 5 ?
             int pages = 400;

            AddBonusPagesByRef(ref pages);

            Console.WriteLine(pages);

        }
            #endregion
    
        static void AddBonusPagesByRef(ref int pages)
        {
            pages += 50;
        }

    }
}