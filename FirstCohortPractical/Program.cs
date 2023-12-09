
#define Debug
#define VC_V6
using FirstCohortPractical;
using System.Linq.Expressions;

public class Program
{
    //Queue
    //Stack
    //Dictionary

    private static void Main(string[] args)
    {

        Teacher teach = new Teacher()
        { 
            Id = 1,
            Name = "Adrian",
        };

        Teacher teach1 = new Teacher()
        {
            Id = 2,
            Name = "Ben",
        };

        Teacher teach2 = new Teacher()
        {
            Id = 3,
            Name = "Grace",
        };

        //Queue
        Queue<Teacher> empqueue = new Queue<Teacher>();

        empqueue.Enqueue(teach);
        empqueue.Enqueue(teach1);
        empqueue.Enqueue(teach2);

        var data = empqueue.Dequeue();
        //Console.WriteLine(data.Id +"  "+ data.Name);

        //stack
        Stack<Teacher> empstack = new Stack<Teacher>();

        empstack.Push(teach);
        empstack.Push(teach1);
        empstack.Push(teach2);

        var datas = empstack.Pop();
        //Console.WriteLine(datas.Id + "  " + datas.Name);


        Dictionary<string, string> contactlist = new Dictionary<string, string>();
        contactlist.Add("Adrian", "09087588765");
        contactlist.Add("Grace", "09142577213");
        contactlist.Add("Liam", "08092938111");
        contactlist.Add("Ben", "07092782812");
        contactlist.Add("Jude", "08142511123");

        foreach(var contact in contactlist)
        {
            Console.WriteLine("Contact-Name: {0}, Phone-Number: {1}", contact.Key, contact.Value);
        }

    }



}
 