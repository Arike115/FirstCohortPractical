using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCohortPractical
{
    //static class
    //generic
    public delegate bool Ispromotable(Teacher teacher); 
    public class Teacher
    {
        //properties
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public decimal TeacherSalary { get; set; }   
        public int Experience { get; set; }

        public static void PromotedTeacher(List<Teacher> teacherlist, Ispromotable isactive)
        {
            foreach(var teacher in teacherlist)
            {
                if(isactive(teacher))
                {
                    Console.WriteLine( teacher.TeacherName + "  is promoted");
                }

            }
        }

    }
}
