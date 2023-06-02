using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    partial class Pessoa
    //partial indica que são classes diferentes do mesmo name space
    {
        public void Apresentar() // método que retorna alguma coisa
        {
            Console.WriteLine("OLá, eu sou o " + nome);
        }

        public static int CalcularIdade(int anoNascimento) //método estático
        {
            return DateTime.Now.Year - anoNascimento;
        }
    }
}
