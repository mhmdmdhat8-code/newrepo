using static System.Console;
namespace asigment__1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            //(Boxing and Unboxing)
            // the first Boxing  وهو تغليف النوع او تحويله من نوع مثلا انتجر في ال ستاك الي الهيب في الاوبجيكت
            int copies = 100;
            object boxedCopies = copies;
            // the seconed un Boxing
            int unboxedCopies = (int)boxedCopies;
            WriteLine(boxedCopies);
            WriteLine(unboxedCopies);
        }
            #endregion
    }


    } 


