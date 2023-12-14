

using FirstCohortPractical;
using System.Linq.Expressions;

public class Program
{
    //Linq
    //language-integrated query
    //query syntax or query expression
    //method syntax or method extension or fluent syntax
    //Linqs have diferrent methods group inside the different categories
    //filtering ===== where, offtype
    //projection ==== select, select many 

    private static void Main(string[] args)
    {
        IList<Teacher> list = new List<Teacher>()
        {
            new Teacher() {Id = 1, Name = "Ada", Age = 98},
            new Teacher() {Id = 2, Name = "Precious", Age = 28},
            new Teacher() {Id = 3, Name = "Emeka", Age = 23},
            new Teacher() {Id = 4, Name = "Grace", Age = 86},
            new Teacher() {Id = 5, Name = "Ben", Age = 45},
        };

        //query syntax
        var adult = from s in list
                    where s.Age > 28
                    select s;

        //method syntax
        var result = list.Where(s => s.Age > 28);

        foreach(var item in adult )
        {
            Console.WriteLine(item.Name);
        }

        List<string> words = new List<string>() {"data","chalk","recharge"};
        var data = words.Select(s => s);
        foreach(var item in data )
        {
            Console.WriteLine(item);
        }
    }



}
 