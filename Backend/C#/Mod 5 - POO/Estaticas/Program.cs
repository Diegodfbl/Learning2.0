using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Estatica
            // matematica m = new matematica();
            // como se trata de uma classe estatica, não dá para estanciar.
            // o que siginifa criar uma nova com novos dados

            //matematica.taxa = 10;

            //int valor1 = matematica.Adicionar(200);
            //int valor2 = matematica.Diminuir(200);

            //Console.WriteLine("O valor com a taxa é: " + valor1);
            //Console.WriteLine("O valor sem a taxa é: " + valor2);

            #endregion

            Pessoa.maioridade = 21;

            Pessoa p1 = new Pessoa();
            p1.nome = "DIEGO";
            p1.idade = Pessoa.CalcularIdade(1991);

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(Pessoa.maioridade);   

            Console.ReadKey();


        }
    }
}
