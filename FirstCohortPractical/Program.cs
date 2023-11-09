using FirstCohortPractical;

public class Program //class
{
    //access modifier

    private static void Main(string[] args) //method
    {
        Console.WriteLine("Teacher's class ......");
        Teacher.CreateFullName("Ben Thomas", 25);
        Teacher.CreateSalary(50000);
        Teacher.CreateJobType("English Teacher");
        Console.WriteLine("Student's class ........");
        Students.CreateFullName("Joseph Benjamin", 13);
        Students.CreateSchoolLevy(150000);
        Console.WriteLine("Otherworker's class .........");
        OtherWorkers.CreateJobType("Gardner");
        OtherWorkers.CreateSalary(55000);

    }






}
