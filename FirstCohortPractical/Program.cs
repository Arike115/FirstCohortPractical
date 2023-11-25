using FirstCohortPractical;

public class Program //class
{
    //generic
    private static void Main(string[] args) //method
    {

        ProgramBase b = new ProgramBase();
        b.newextensionmethod();
        string words = "cupboard";
       var result = words.LowercaseValue();
        Console.WriteLine(result);

    }






}
