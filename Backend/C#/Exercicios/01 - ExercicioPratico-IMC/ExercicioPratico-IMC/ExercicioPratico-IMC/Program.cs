using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPratico_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, IMC;
            string nome1, nome2, grau1, grau2, grau3, grau4, grau5, grau6;

            grau1 = "Você está baixo do peso.";
            grau2 = "Parabéns, seu peso está normal.";
            grau3 = "Atenção! Você está com sobrepeso.";
            grau4 = "Obesidade grau I.";
            grau5 = "Obesidade grau II.";
            grau6 = "Obesidade grau III(Obesidade mórbida).";



            Console.WriteLine("Digite seu 1º nome: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite seu ultimo nome: ");
            nome2 = Console.ReadLine();

            
            Console.WriteLine("Seu nome completo é: " + nome1 + " " + nome2 );
            Console.WriteLine();

            Console.WriteLine("Agora vamos iniciar a coleta de dados para o cálculo de seu IMC " +nome1);
            Console.WriteLine("Digite seu Peso. Ex.: 108,78");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua Altura. Ex.: 1,79");
            altura = double.Parse(Console.ReadLine());

            IMC = peso / (altura * altura);
            Console.WriteLine("Seu IMC é: " + IMC);

            if (IMC < 18.5)
            {
                Console.WriteLine(grau1);
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                Console.WriteLine(grau2);
            }
            else if (IMC >= 25 && IMC <= 29.9)
            {
                Console.WriteLine(grau3);
            }
            else if (IMC >= 30 && IMC <= 34.9)
            {
                Console.WriteLine(grau4);
            }
            else if (IMC >= 35 && IMC <= 39.9)
            {
                Console.WriteLine(grau5);
            }
            else if (IMC >= 40 )
            {
                Console.WriteLine(grau6);
            }


            // Console.WriteLine(nome);
            Console.WriteLine("Pressione qualquer tecla para sair....");
            Console.ReadKey();
        }

    }
}
