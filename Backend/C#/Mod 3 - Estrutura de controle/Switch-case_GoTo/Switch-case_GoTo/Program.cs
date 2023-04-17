using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case_GoTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region Switch_Case
        //SWITCH CASE - Escolhe uma seção com base em uma correspondência

        //Console.WriteLine("Programa de Conversão, nº em Dia da Semana");
        //Console.WriteLine("Digite um numero entre 1 a 7");
        //int diaSemana = int.Parse(Console.ReadLine());


        //switch (diaSemana)
        //{
        //    default:
        //        Console.WriteLine("Número digitado é inválido. Favor refazer.");
        //        break;

        //    case 1: // como o switch testa casos da variável teste, que é inteiro, só podemos colocar o caso como numero inteiro
        //        Console.WriteLine("DOMINGO");
        //        break; // todo caso precisa ter um break pois o switch executa o caso até achar um break

        //    case 2:
        //        Console.WriteLine("Segunda-feira");
        //        break;

        //    case 3:
        //        Console.WriteLine("Terça-feira");
        //        break;

        //    case 4:
        //        Console.WriteLine("Quarta-feira");
        //        break;
        //    case 5:
        //        Console.WriteLine("Quinta-feira");
        //        break;
        //    case 6:
        //        Console.WriteLine("Sexta-feira");
        //        break;
        //    case 7:
        //        Console.WriteLine("Sábado");
        //        break;
        //}
        #endregion

        Inicio: // LABEL = INICIO< retomada caso o usuário digite algo fora do esperado.
            //Um LABEL pode ser personalizado de acordo com o nome que eu preferir, pode estar em qqr lugar do código

            Console.Write("Teste de Opções, escolha entre Opção, 1 ou 2: ");
            int op = int.Parse(Console.ReadLine());
            int valor = 0;

            switch (op)
            {
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    Console.WriteLine("");
                    goto Inicio; // Se o usuáio digitar algo fora das opções ele tem a opção de reiniciar o teste, pois ele volta la pro LABEL Inicio.
                    
                    case 1:
                    valor += 100;
                    break;
                    case 2:
                    valor += 50;
                    goto case 1;

            }
            Console.WriteLine("O Valor é:" + valor);
            Console.WriteLine();

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
