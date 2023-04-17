using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Clear();

            Console.WriteLine("Aplicação para calculo matemático");
            Console.WriteLine("As Opções são: ");
            Console.WriteLine("1- SOMA;");
            Console.WriteLine("2- SUBTRAÇÃO;");
            Console.WriteLine("3- MULTIPLICAÇÃO;");
            Console.WriteLine("4- DIVISÃO.");
            Console.WriteLine("Selecione um número de 1 a 4 para escolher");

            

            int op = int.Parse(Console.ReadLine());
            double total = 0;
            
            Console.WriteLine("Digite o primeiro número da operação: ");
            double num1 = double.Parse(Console.ReadLine());
    
            
            
            Console.WriteLine("Digite o segundo número da operação: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (op) 
            {
                default: Console.WriteLine("Número inválido");
                    break;

                case 1: 
                    Console.WriteLine("Operação será de SOMA");
                    total = num1 + num2;
                    break;

                case 2:
                    Console.WriteLine("Operação será de SUBTRAÇÃO");
                    total = num1 - num2;
                    break;
                case 3:
                    Console.WriteLine("Operação será de MULTIPLICAÇÃO");
                    total = num1 * num2;
                    break;
                case 4:
                    Console.WriteLine("Operação será de DIVISÃO");
                    if (num2 != 0)
                    {
                        total = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine($"Não é possível dividir {num1} por zero.");
                    }
                    break;
                 
            }

            Console.WriteLine($"O resultado é: {total}");

            Console.WriteLine("Continuar calculando? (s ou n)? ");
            string resp = Console.ReadLine();
            if (resp == "s" || resp == "S")
            {
                goto Inicio; 
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
