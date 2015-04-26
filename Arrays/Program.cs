using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array simples
            int[] a1 = new int[3];
            a1[0] = 10;

            //Array dinâmico
            int[] a2 = new int[] {0, 10, 11, 32};

            string[] a3 = { "01", "03", "03" };
            int length = a3.Length;
            string value = a3[2];

            //Array multidimensional (linhas, colunas)
            int[,] m1 = new int[3, 3];
            m1[0, 0] = 10;

            //Object Array
            ArrayList al = new ArrayList();
            al.Capacity = 10;
            al.Add("01");
            al.Add(1);

            string valueAl = (string) al[0];

            //Generics List<T> - se adapta a um tipo
            List<int> l = new List<int>();
            l.Add(1000);

            //foreach
            foreach (int v in l) {
                Console.WriteLine(v);
            }
            Console.ReadKey();
        }
    }
}
