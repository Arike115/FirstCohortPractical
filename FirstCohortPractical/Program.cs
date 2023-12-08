
#define Debug
#define VC_V6
using FirstCohortPractical;
using System.Linq.Expressions;

public class Program //class
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args) //method
    {
        Teacher.calculator(45, 36);
        var numbers = new List<int> { 64, 37, 89, 0, 23 };
        Teacher.newcalculator(numbers);

#if (DEBUG && !VC_V6)
        Console.WriteLine("Debug is defined");
#elif (!DEBUG && VC_V6)
        Console.WriteLine("VC_V6 is defined");
#elif (DEBUG && VC_V6)
        Console.WriteLine("Debug and VC_V6 are defined");
#else
        Console.WriteLine("Debug and VC_V6 are not  defined");
#endif
    }

}
 