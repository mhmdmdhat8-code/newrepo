using static System.Console;
namespace asigment__1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";, use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            string badText = "abc";
            int result;
            bool isSuccess = int.TryParse(badText, out result);

            if (isSuccess == false)
            {
                WriteLine("Invalid number");
            }
            #endregion
            }


    }
}
