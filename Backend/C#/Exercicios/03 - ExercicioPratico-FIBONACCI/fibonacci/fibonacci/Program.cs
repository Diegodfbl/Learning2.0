using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo da Sequência de FIBONACCI");
            Console.WriteLine("");

            Console.Write("Digite um número para gerar a sequência de Fibonacci: ");
            // Console.ReadLine();
            int num = int.Parse(Console.ReadLine());

            int num1 = 0, num2 = 1, num3 = 0;

            Console.Write("Sequência de Fibonacci: ");

            for (int i = 0; i < num; i++) 
            {
                if (i <= 1){
                    num3 = i;
                } else {
                    num3 = num1 + num2;
                    num1 = num2;
                    num2 = num3;
                }

                Console.Write(num3 + " ");
            }
            
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair.....");
            Console.ReadKey();
        }
    }
}
