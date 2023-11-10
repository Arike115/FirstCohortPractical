using FirstCohortPractical;

public class ProgramBase
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Gender Gender { get; set; }
    public DayOfWeek DayOfWeek { get; set; }

    public void CreateUser()
    {
        Console.WriteLine("The user in charge is a {0}", Gender.Male);
        Console.WriteLine("The current day is {0}",DayOfWeek.Sunday);
    }
}