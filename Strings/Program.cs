using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "one,two,three";
            
            string s2 = "one";
            s2 += ",two";
            s2 += ",three";

            System.Text.StringBuilder sb = new StringBuilder();
            sb.Append("one");   
            sb.Append(",two");
            sb.Append(",three");
            Console.WriteLine(sb);
            Console.ReadKey();


            //manipulação básica praticamente igual ao java -.-
        }
    }
}
