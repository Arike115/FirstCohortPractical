

using FirstCohortPractical;
using System.Linq.Expressions;

public class Program
{
    //Linq
    //language-integrated query
    //query syntax or query expression
    //method syntax or method extension or fluent syntax
    //Linqs have different methods group inside the different categories
   //Element Operators
   //Aggregate Operators
   //Quantifiers ====> any, all, contains

    private static void Main(string[] args)
    {
        //Quantifiers
        string[] words = { "pen", "chalk", "duster", "desk", "jug", "mug" };

        var anyresult = words.Any(s => s.Length > 4);
        Console.WriteLine(anyresult);

        var allresult = words.All(s => s.Length > 4);
        Console.WriteLine(allresult);

        var contresult = words.Contains("chalk");
        Console.WriteLine(contresult);

        //aggregate operators
        //sum
        //min
        //max
        //count
        //average
        //aggregate

        int[] numeric = { 45, 6, 7, 8, 2, 2, 4, 90, 89, 45, 0, 23 };

        var sum = numeric.Sum();
        Console.WriteLine("sum = " + sum);
        var min = numeric.Min();
        Console.WriteLine("minimum = " +min);
        var max = numeric.Max();
        Console.WriteLine("maximum =" + max);
        var count = numeric.Count();
        Console.WriteLine("Count = " + count);
        var avarage = numeric.Average();
        Console.WriteLine("avaerage = " +avarage);


        //element Operators
        //first
        //firstordefault
        //last
        //lastordefault
        //single
        //singleordefault

        int[] numerics = { 45, 6, 7, 8, 2, 2, 4, 90, 89, 45, 0, 23 };
        int[] numerics2 = { };

        var v = numerics.First();
        Console.WriteLine(v);
        var y = numerics.FirstOrDefault();
        Console.WriteLine(y);
        var i = numerics2.FirstOrDefault();
        Console.WriteLine(i);

        var o = numerics.Last();
        Console.WriteLine(o);
        var n = numerics.LastOrDefault();
        Console.WriteLine(n);
        var z = numerics2.LastOrDefault();
        Console.WriteLine(z);

    }



}
 