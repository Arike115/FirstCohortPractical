using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCohortPractical
{
    //attributes
    //preprocesor-directives
    //xml documentation

    public class Teacher
    {
        //attributes
        //serialization attributes
        //nonserialization attributes
        //Obsolete
        //web method


        #region please do not change the parameters in this code
        //atributes
        /// <summary>
        /// this calculator method calculate two values
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        [Obsolete("this method is outdated pls make use of the second Method called :'newcalculator(List<int> values)' ")]
        public static void calculator(int value1 , int value2)
        {
            var result = value1* value2;
            Console.WriteLine(result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        public static void newcalculator(List<int> values)
        {
           var result= values.AsQueryable().Sum();
            Console.WriteLine(result);
        }

        #endregion
    }
}
