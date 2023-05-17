using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {

            // ASSINATURA () METEDO CONSTRUTOR
            Pessoa p1 = new Pessoa(); 

            Console.Write(p1.nome + " ");
            Console.WriteLine(p1.sobrenome);
            Console.WriteLine(p1.anonasc);
            Console.WriteLine("Sua idade é: " + p1.idade);
            Console.WriteLine();

            Pessoa p2 = new Pessoa("DIEGO", "B LIMA", 1991);

            Console.Write(p2.nome + " ");
            Console.WriteLine(p2.sobrenome);
            Console.WriteLine(p2.anonasc);
            Console.WriteLine("Sua idade é: " + p2.idade);
            Console.WriteLine();


            Pessoa p3 = new Pessoa("Isabela", "B LIMA",1993);

            Console.Write(p3.nome + " ");
            Console.WriteLine(p3.sobrenome);
            Console.WriteLine(p3.anonasc);
            Console.WriteLine("Sua idade é: " + p3.idade);
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
