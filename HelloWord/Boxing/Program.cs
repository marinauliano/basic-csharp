using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //Representa todo tipo de classe possível dentro do .net. Tipo o TObject do delphi
            //System.Object;

            int a = 10;
            
            //realizou um Boxing
            object o = (object)a;

            System.Type type = o.GetType();

            Console.WriteLine(o.GetType().ToString());
            Console.ReadKey();
        }
    }
}
