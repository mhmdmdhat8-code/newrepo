using static System.Console;
namespace asigment__1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
            int pagesNum2 = 464;

            // 1. نحوله لنص بـ ToString()
            string textPages = pagesNum2.ToString();

            // 2. نطبع نوع المتغير بـ GetType() عشان نتأكد
            WriteLine(textPages.GetType());
            #endregion
        }


    }
}
