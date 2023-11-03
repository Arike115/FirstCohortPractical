public class Program //class
{
    //paramaters
    //Operators
    //Arithmetic operators +,-,*,/,%,++ => increment of 1, -- decrement of 1
    //Asignment Operators =,+=,-=,??
    //Comparison Operators >,<,<=,>=
    //logical operators
    //relational operators
    //Statements
    //Conditional statement, if else, switch case
    //conditional looping, for, foreach, do, dowhile

    static int v = 10;
    static int x = 134;//field
    static int y = 56;
                            //parameters
    private static void Main(string[] args) //method
    {

        DiceGame();

        int result = v + x;
        result -= y;
        Console.WriteLine(result);

        //If else statement
        if (v >= y && x > y)
        {
            Console.WriteLine("the result is real");
        }
        else
        {
            Console.WriteLine("the result is fake");
        }

        if (v == 10 && x >= 56 && y < 100)
        {
            Console.WriteLine("Genius Result");
        }
        else
        {
            Console.WriteLine("not good");
        }

        if (v == 20 || x >= 56)
        {
            Console.WriteLine("Or Logical Result");
        }
        else
        {
            Console.WriteLine("not good");
        }


        //switch case statement
        int day = 7;

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursdays");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            default:
                Console.WriteLine("day does not exist");
                break;
        }
    }

    public static void DiceGame()
    {
        Console.WriteLine("Pick your lucky Number from 1 to 10");
        int result = int.Parse(Console.ReadLine());

        switch(result)
        {
            case 1:
            case 2:
                Console.WriteLine("oops try again later");
                break;
            case 3:
            case 4:
                Console.WriteLine("Congratulations you won 1 million naira");
                break;
            case 5:
            case 6:
                Console.WriteLine("you lost");
                break;
            case 7:
            case 8:
                Console.WriteLine("Congratulations you won a free ticket");
                break;
            case 9:
            case 10:
                Console.WriteLine("almost there guess today is not your lucky day");
                break;
            default:
                Console.WriteLine("Wrong Number pls try next time");
                break;
        }


    }

    
   
   
}
