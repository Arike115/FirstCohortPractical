using FirstCohortPractical;

public class Program //class
{
    //access modifier

    private static void Main(string[] args) //method
    {
        ////static class
        //Teacher.CreateSalary(6600);

        //non.static class
        //instance
        Students info = new Students("Toyota Camry", 3000000, "2019mv"); //instantiation 
        info.CarDetails();
        info.CarAmount();
       

        //Students.CreateFullName("johin", 89);
      
    }






}
