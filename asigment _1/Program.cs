using static System.Console;
namespace asigment__1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            try
            {
                // divice 10 by 0 
                int num = 10;
                int zero = 0;
                int result = num / zero;
            }

            catch (Exception)
            {
                WriteLine("Cannot divide by zero");
            }

            finally
            {
                WriteLine("done");
            }
            #endregion
        }


    }
}
