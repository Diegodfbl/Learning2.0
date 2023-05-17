using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___Teoria
{
    class Pessoa
    {
        // atributos / campos                                      da classe PEssoa
        public string nome;
        public string sobrenome;
        public int anoNasc;
        public int idade;
  


        // método simples é um método que realiza uma função e nao retorna valor
        public void Cummprimentar() //public, modificador de acesso. || void significa vazio, sem retorno
        {
            Console.WriteLine("Ola, eu sou " + nome + " " + sobrenome);
        }
        
    }
}
