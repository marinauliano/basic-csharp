using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypes
{

    //pode-se mudar o valor inicial
    enum acessorios { sapato=5, bolsa, cinto, carteira, colar }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            String a = "Ok";

            float ff = 13.99f;    //até 7 digitos de precisão
            double dd = 99.9999;  // de 15 a 16 digitos de precisão
            decimal dec = 10.88m; //28 à 29 digitos decimais e usado para finanças

            //Convertendo string para inteiro, também existe int.TryParse()
            int strToInt = int.Parse("12345");
            
            //***ver msdn c# programmer guide, para saber mais sobre o framework***

            //Outro tipo de framework para conversão
            Console.WriteLine(Convert.ToChar(65));

            Console.WriteLine((int) acessorios.colar);
            Console.ReadKey();
        }
    }
}
