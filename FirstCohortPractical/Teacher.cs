using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCohortPractical
{
        //static class   
    public static class Teacher 
    {
        public static void CreateSalary(decimal Schoollevy)
        {
            Console.WriteLine("The salary amount = {0}", Schoollevy);
        }

        public static void CreateJobType(string jobtype)
        {
            Console.WriteLine("The StaffRole is = {0}", jobtype);
        }
    }
}
