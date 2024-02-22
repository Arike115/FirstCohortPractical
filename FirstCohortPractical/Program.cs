using FirstCohortPractical;
using System.Linq.Expressions;

public class Program //class
{
    //exception handling
    //try
    //catch
    //finally
    private static void Main(string[] args) //method
    {
        //array
        try
        {
            int[] numbers = { 6, 5, 6, 7, 8 };
            Console.WriteLine(numbers[11]);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
       
    }



}
 