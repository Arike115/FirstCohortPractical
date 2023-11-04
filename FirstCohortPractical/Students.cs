using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCohortPractical
{
  //accessmodifier
  //public
  //private
  //internal
  //protected
    class Students
    {
       public static int v = 89; //field

        public static void StudentName()
        {
            Console.WriteLine("welcome to this new topic");
            StudentList();
        }

        private static void StudentList()
        {
            string[] studentdate = { "chioma", "Adanma", "Ngozie", "Ejiro", "Ben" };
            foreach (string s in studentdate) 
            {
                Console.WriteLine(s);
            }
        }
    }
}
