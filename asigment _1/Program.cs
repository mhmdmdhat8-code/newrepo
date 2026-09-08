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
            #region Using the same books array, use a while loop to print every book title.
            int count = 0;
            do
            {
                WriteLine("Checking book...");
                count++;
            }
            while (count < 3);
            #endregion
        }
    }
}
