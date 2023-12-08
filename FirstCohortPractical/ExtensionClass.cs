using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//xml documentaion
namespace FirstCohortPractical
{

    /// <summary>
    /// Extension class is use for extension methods
    /// </summary>
    public static class ExtensionClass
    {
       
        /// <summary>
        /// this method works with string datatypes alone
        /// </summary>
        /// <param name="name"></param>
        public static void ExtensionInfo(this string name)
        {
            Console.WriteLine(name);
        }
    }
}
