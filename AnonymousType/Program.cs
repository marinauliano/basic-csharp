using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ

            //única forma de fazer numericos ser nulo
            int? i = null;

            var name = new[] {new { idade = 18, nome = "Luis" }, new {idade = 23, nome="Amanda"}};

            foreach (var item in name) {
                Console.WriteLine(item.idade);
            }

            Console.ReadKey();

            //Console.WriteLine(name[0].idade);

            //Operadores lógicos
            //xor = ^       

            //Opeardores condicionais
            //and = &&
            //or = ||

        }
    }
}
