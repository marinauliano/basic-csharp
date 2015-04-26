using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//tecla de atalho mágina ctrl + .
namespace ClassAluno
{
    class Aluno
    {
        //constructor
        public Aluno()
        {
            Console.WriteLine("Aluno constructor.");
        }

        private string nome;
        private int idade;

        //escreve prop; digita tab e ele cria o template
        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                if (value >= 18)
                {
                    idade = value;
                }
                else
                {
                    throw new Exception("Idade não pode ser menor que 18.");
                }
            }
        }

        public string[] Parse(String value)
        {
            return value.Split(';');
        }

        public void AlteraNome(string newName)
        {
            Nome = newName;
        }

        ~Aluno()
        {
            Console.WriteLine("Aluno destructor.");
            // Console.ReadKey();
        }


    }
}
