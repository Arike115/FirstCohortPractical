using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCohortPractical
{
        //static class
        //generic
    public static class Teacher<T> 
    {
        public static void CreateSalary(T Schoollevy)
        {
            Console.WriteLine("The salary amount = {0}", Schoollevy);
        }

        public static void CreateJobType(string jobtype)
        {
            Console.WriteLine("The StaffRole is = {0}", jobtype);
        }


        public static T calculator(T value1, T value2, T value3)
        {
            return value2;
        }
    }
}
