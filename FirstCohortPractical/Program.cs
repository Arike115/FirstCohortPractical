public class Program //class
{
    //Statements
    //Conditional statement, if else, switch case
    //conditional looping, for, foreach, while, dowhile

    private static void Main(string[] args) //method
    {
        decimal[] values = {12,90.8m,78,65.7m,89.90m,764.0m,89 }; 

        ////Foreach
        //foreach(decimal data in values)
        //{
        //    Console.WriteLine(data);
        //}

        //for
      //field declaration
        for(int v = 10; v >= 0; v-- )
        {
            Console.WriteLine(v);
        }
        //dowhile

        int i = 0;
        do
        {
            Console.WriteLine("value of i =" + i);
            i++;
        }while (i < values.Length);

        //while
        int x = 0; //declaration
        while (x < values.Length) //setting condition
        {
            Console.WriteLine("value of x =" + x);
            x++; //increment 
        }
    }

   

    
   
   
}
