
#define Debug
#define VC_V6
using FirstCohortPractical;
using System.Linq.Expressions;

public class Program
{
    //ICollection
    //IList
    //List

    private static void Main(string[] args) 
    {
        List<string> Data = new List<string>();
        Data.Add("chalk");
        Data.Add("Tyron");
        Data.Add("Clone");
        Data.Add("Reserve");
        Data.Add("Align");
        Data.Add("Disregard");

        CollectionDisplay(Data);
        IListDisplay(Data);
        ListDisplay(Data);

    }

    public static void CollectionDisplay(ICollection<string> mylist)
    {
        mylist.Remove("");
        foreach(var item in mylist)
        {
            Console.WriteLine("the icollection elements are as follows:" + item);
        }
    }

    public static void IListDisplay(IList<string> mylist)
    {
        mylist.RemoveAt(3);
        foreach (var item in mylist)
        {
            Console.WriteLine("the IList elements are as follows:" + item);
        }
    }

    public static void ListDisplay(List<string> mylist)
    {
        mylist.Sort();
        mylist.ElementAt(0);
        foreach (var item in mylist)
        {
            Console.WriteLine("the List elements are as follows:" + item);
        }
    }

}
 