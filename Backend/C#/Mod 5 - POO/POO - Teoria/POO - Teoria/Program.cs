using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO___Teoria
{
    
    class Program
    {
        static void Main(string[] args)
        {
            #region aula1
            MinhaClasse mClasse = new MinhaClasse();
            MinhaClasse m2 = null;
            //criação de novos objetos da classe MinhaClasse
            Class1 class1 = new Class1();
            #endregion

            Pessoa p1 = new Pessoa();
            p1.nome = "Diego F";
            p1.sobrenome = "Bortholace Lima";
            p1.anoNasc = 1991;

            Pessoa p2 = new Pessoa()
            {
                nome = "Isabela",
                sobrenome = "B Lima",
                anoNasc = 1993

            };
            p1.nome = "Dieguito";

            Console.WriteLine("Pessoa 1 : " + p1.nome);
            Console.WriteLine("Pessoa 1 : " + p1.sobrenome);
            Console.WriteLine("Pessoa 1 : " + p1.anoNasc);
            p1.Cummprimentar(); // maneira de refenciar os métodos da classe

            Console.WriteLine();

            Console.WriteLine("Pessoa 2 : " + p2.nome);
            Console.WriteLine("Pessoa 2 : " + p2.sobrenome);
            Console.WriteLine("Pessoa 2 : " + p2.anoNasc);
            p2.Cummprimentar();

            Console.ReadKey();
        }
    }

    class MinhaClasse //criação de classe personalizada
    {
        //melhor criar novas classe em outros arquivos dentro do projeto. Para melhor organização do código
    }
}
