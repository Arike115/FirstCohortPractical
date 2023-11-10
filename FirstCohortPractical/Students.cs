using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCohortPractical
{
   //static and non-static method, class, field and properties
   //nonstatic class
    public class Students
    {
        string CarName;
        int CarPrice;
        string CarModel;

        //constructor
        public Students(string name, int price, string model) 
        { 
            CarName = name;
            CarPrice = price;
            CarModel = model;
        }
       
        public static void CreateFullName(string Fullname, int Age)
        {
            DateTime DOB = DateTime.Now;
            Console.WriteLine("The Name is {0}, he/she is {1} years old, he/she was born on{2}", Fullname,Age, DOB);
        }

        public static void CreateSchoolLevy(decimal Schoollevy)
        {
            Console.WriteLine("The schoolLevy amount{0}",Schoollevy );
        }

        public void CarDetails()
        {
            Console.WriteLine("The car Name is = {0}, it is going out for " +
                " = {1}, it is {2} Model", CarName, CarPrice, CarModel);
        }
        public void CarAmount()
        {
            Console.WriteLine("The CarPrice = {0}", CarPrice);
        }
    }
}
