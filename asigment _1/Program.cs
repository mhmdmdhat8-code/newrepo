using static System.Console;
namespace asigment__1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            // هعمل نسخة من الكتاب واملي بيانتها 
            Book mybook = new Book();
            mybook.title = "C# Programming";
            mybook.page = 464;
            // هخزن النسخة دي جوه متغير من نوع object 
            Object objbook = mybook;
            // هنطبع المتغير 
            WriteLine(objbook);
            #endregion

        }


    }
}
