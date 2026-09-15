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
            #region Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to see, and why?
            double[] prices = { 25.5, 40.0 };

            // استدعاء الدالة وتمرير المصفوفة
            ApplyDiscount(prices);

            // طباعة السعر الأول بعد التعديل
            Console.WriteLine(prices[0]);
            // Why>> لأن المصفوفات Reference Types. الدالة استلمت العنوان اللي بيشاور على مكان المصفوفة في الذاكرة، والتعديل اللي حصل على prices[0] غير في المصفوفة الحقيقية.
            #endregion
        }
        static void ApplyDiscount(double[] prices)
        {
            prices[0] -= 5; // تخصم 5 من أول عنصر
        }
    }

    }  
