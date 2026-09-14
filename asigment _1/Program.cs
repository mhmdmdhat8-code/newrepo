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
            #region Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable int pages = 400; and print pages afterward. What do you expect to see, and why?
            int pages = 400;
            AddBonusPages(pages);
            WriteLine(pages);
            //طبعت 400 
            //لأن C# قامت بتمرير المتغير Pass by Value. الدالة استلمت نسخة من الرقم (400) وزودت عليها 50 فبقت (450) جوه نطاق الدالة فقط، لكن المتغير الأصل pages جوه الـ Main يظل كما هو دون تغيير
            #endregion
        }
        static void AddBonusPages(int pages)
        {
            pages += 50; // أو pages = pages + 50;
        }
    }

    }  
