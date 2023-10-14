public class Program //class
{ //opening of a class

    //Datatypes
    //string
    //interger int
    //decimal
    //float
    //long
    //double
    //bool
    //short
    //byte
    //string
    //how to declare a datatype

    static string Words = "chalk-board";
    static int Number = 45362483;
    decimal value = 127.6453m;
    double v = 21632867394674764.557;
    bool y = true;
    float x = 374526664234742671423534678438683.7f;
    long h = 219236754954239512;
    byte o = 217;
    short k = 7823;

    //array
    static string[] Data = { "wardrobe", "carpet", "chalk", "plate", "cup" };
    int[] Numerical = { 675, 894, 464, 46737, 7463 };
    private static void Main(string[] args) //method
    {//opening of your method
        //{} curly braces

        //statement
        Console.WriteLine(Words);
        Console.WriteLine(Number);
        Console.WriteLine(999);

        //how to print an array
        foreach (string  s in Data) 
        {
            Console.WriteLine(s);
        }

        Console.WriteLine("End of the class");

    }//closing of your method
   
   
}//closing of the class
