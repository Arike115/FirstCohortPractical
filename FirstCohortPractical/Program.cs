using FirstCohortPractical;
using System.Linq.Expressions;

public delegate void Hellodelegate(string message);
public class Program //class
{
    //Delegate
    //lamdba expression
    //anonymous method
    //exception handling
    private static void Main(string[] args) //method
    {
        ////a delegate is a type safe function pointer
        //Hellodelegate del = new Hellodelegate(Hello);
        //del("welcome to delegate");

        List<Teacher> techlist = new List<Teacher>();
        techlist.Add(new Teacher() { TeacherId = 1, TeacherName = "Grace",TeacherSalary = 150000, Experience = 2});
        techlist.Add(new Teacher() { TeacherId = 2, TeacherName = "Ben", TeacherSalary = 2000000, Experience = 3 });
        techlist.Add(new Teacher() { TeacherId = 3, TeacherName = "Ruth", TeacherSalary = 170000, Experience = 4 });
        techlist.Add(new Teacher() { TeacherId = 4, TeacherName = "John", TeacherSalary = 190000, Experience = 5 });
        techlist.Add(new Teacher() { TeacherId = 5, TeacherName = "Lola", TeacherSalary = 100000, Experience = 7 });
        techlist.Add(new Teacher() { TeacherId = 6, TeacherName = "Tayo", TeacherSalary = 150000, Experience = 8 });
        techlist.Add(new Teacher() { TeacherId = 7, TeacherName = "Shola", TeacherSalary = 200000, Experience = 3 });
        techlist.Add(new Teacher() { TeacherId = 8, TeacherName = "Levi", TeacherSalary = 120000, Experience = 9 });
        techlist.Add(new Teacher() { TeacherId = 9, TeacherName = "Joshua", TeacherSalary = 150000, Experience = 2 });
        techlist.Add(new Teacher() { TeacherId = 10, TeacherName = "ken", TeacherSalary = 190000, Experience = 1 });

        //Ispromotable promo = new Ispromotable(promote);
                                           // LambdaExpression
        Teacher.PromotedTeacher(techlist, p => p.Experience >=5);
       
    }

    //function
    //public static bool promote (Teacher teacher)
    //{
    //   if(teacher.TeacherId >=6)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}






}
