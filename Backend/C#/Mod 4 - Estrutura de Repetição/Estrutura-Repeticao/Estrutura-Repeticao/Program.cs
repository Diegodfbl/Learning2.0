using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura_Repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region WHILE
            // WHILE - Repete a estrutura enquanto a operação retornar TRUE, quando for FALSE ele sai da estrutura.
            //int valor = 0;

            //while (valor < 10)
            //{
            //    Console.WriteLine($"O Valor é {valor}");
            //    valor++;
            //}
            #endregion

            #region DO-WHILE
            //Primeiro ele executa a estrutura de repetição para depois fazer o teste da condição, se TRUE ele continua.
            //int valor = 0;
            //do 
            //{
            //    Console.WriteLine($"O valor é: {valor} ");
            //    valor++;
            //} while (valor < 10);

            #endregion

            #region FOR

            //for (int i = 1, j = 10; i <= 10; i++, j--) // 3 seções separadas por ; 1- variavel de controle(executada somente na 1ª passagem). 2- condição(verificação). 3- incremento.
            //{
            //    Console.Write($" O valor de I é: {i}| ");
            //    Console.WriteLine($"| E de J é: {j}");
            //}

            #endregion

            #region FOREACH

            //string[] nomes = { "Diego", "Fernando", "Bortholace", "Lima" };
            //string nome;

            //foreach (string name in nomes) // var item in Collection "var" para quando nao se sabe o tipo de arquivos que vai tirar do array || 
            //{
            //    Console.WriteLine($"O nome é: {name}");
            //}

            #endregion

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
