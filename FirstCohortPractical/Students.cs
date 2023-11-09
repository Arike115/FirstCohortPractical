using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCohortPractical
{
    //inheritance
    public class Students //base class
    {

        public static void CreateFullName(string Fullname, int Age)
        {
            DateTime DOB = DateTime.Now;
            Console.WriteLine("The Name is {0}, he/she is {1} years old, he/she was born on{2}", Fullname,Age, DOB);
        }

        public static void CreateSchoolLevy(decimal Schoollevy)
        {
            Console.WriteLine("The schoolLevy amount{0}",Schoollevy );
        }
    }
}
