

using FirstCohortPractical;
using System.Linq.Expressions;

public class Program
{
    //Linq
    //language-integrated query
    //query syntax or query expression
    //method syntax or method extension or fluent syntax
    //Linqs have different methods group inside the different categories
    //set operators
    //ordering methods
    //conversion method

    private static void Main(string[] args)
    {

        double[] numbers1 = { 2.1, 2.2, 2.3, 2.4, 2.5, 2.6, 2.4, 2.1, 2.8 };
        double[] numbers2 = { 2.9, 2.4, 2.2, 2.10, 2.11, 23, 22 };

        var result = numbers1.Distinct().ToArray();
        var data = numbers2.Except(numbers1).ToList();
        var intersect = numbers1.Intersect(numbers2).ToList();
        var union = numbers1.Union(numbers2).ToList();
        foreach (double number in union)
        {
            Console.WriteLine(number);
        }


        IList<Teacher> list = new List<Teacher>()
        {
            new Teacher() {Id = 1, Name = "Ada", Age = 98},
            new Teacher() {Id = 2, Name = "Precious", Age = 28},
            new Teacher() {Id = 3, Name = "Emeka", Age = 23},
            new Teacher() {Id = 3, Name = "Grace", Age = 86},
            new Teacher() {Id = 4, Name = "Ben", Age = 28},
        };

        //Querysyntax

        var orderbydatas = from s in list
                          orderby s.Id
                          select s;


        var orderbydatadescen = from s in list
                                orderby s.Id descending
                                select s;

        var orderbydata = list.OrderBy(x => x.Age).ThenBy(x => x.Name);


        foreach(var v in orderbydata)
        {
            Console.WriteLine("the id = {0} and the Name = {1}",v.Id, v.Name);
        }
    }



}
 