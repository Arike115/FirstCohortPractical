using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCohortPractical
{
    public static class ExtensionClass
    {
        public static void newextensionmethod(this ProgramBase bas)
        {
            Console.WriteLine("hello i'm here");
        }


        public static string LowercaseValue(this string value)
        {
            var data = value.ToUpper();
            return data;

        }
    }
}
