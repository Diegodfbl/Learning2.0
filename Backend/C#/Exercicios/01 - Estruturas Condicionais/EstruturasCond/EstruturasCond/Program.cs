using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasCond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ANOTAÇÃO
            // introdução, ajuda na tomada de decisão. 
            // Condição é a expressao de que pode ser TRUE or FALSE; BOOLEANO
            // As condições nas operações podem ser formadas utilizando os operadores de igualdade(== ou !=) e os operadores relacionais(> < >= <=)
            #endregion

            #region SIMPLES-IF/ELSE

            //int a = 0;
            //Console.WriteLine("Digite um número qualquer: ");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("");

            //    if (a % 2 == 0)
            //    {

            //        Console.WriteLine("O nº " + a + " é PAR");
            //        Console.WriteLine("");  
            //    }
            //    else
            //    {
            //        Console.WriteLine("O nº " + a + " não é IMPAR");
            //        Console.WriteLine("");
            //    }

            #endregion

            #region ENCADEADA

            //Console.WriteLine("Digite um número entre 0 a 15: ");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("");

            //if (b < 10)
            //{

            //    Console.WriteLine("O nº digitado é menor que 10.");
            //    Console.WriteLine("");
            //}
            //else if (b >= 10 && b <=14) // não pode conflitar com nenhuma outra condição
            //{
            //    Console.WriteLine("O nº digitado é maior que 10 e menor ou igual a 14.");
            //    Console.WriteLine("");
            //}
            //else if (b == 15)
            //{
            //    Console.WriteLine("O nº digitado é igual a 15.");
            //    Console.WriteLine("");
            //}
            //if (b > 15)
            //{
            //    Console.WriteLine("O nº digitado é maior que 15.");
            //    Console.WriteLine("Favor fazer novamente.");
            //    Console.WriteLine("");
            //}
            #endregion

            #region ANINHADAS

            //int c;
            //Console.WriteLine("Digite um número qualquer: ");
            //c = int.Parse(Console.ReadLine());
            //Console.WriteLine("");

            //if (c >= 10)
            //{
            //    Console.Write("É um numero maior que 10 ");

            //    if (c % 2 == 0)
            //    {
            //        Console.WriteLine("e também é par.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("e també é impar.");
            //    }
            //}
            //else 
            //{
            //    Console.WriteLine("Favor digitar um número maior que 10");
            //}

            #endregion

            #region Operador-Ternário
            int d;
            Console.WriteLine("Digite um número de 0 a 10: ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            
            // string msg = d > 5 ? "Maior que 5." : "Menor que 5."; expressão condicional sendo tratada e atribuida numa variavel
            
            // condição ? true : false;

            // msg = d > 5 ? "Maior que 5." : "Menor que 5.";

            //if (d > 5)
            //{
            //    msg = "Maior que 5.";
            //}
            //else
            //{
            //    msg = "Menor que 5.";
            //}
            

            Console.WriteLine(d > 5 ? "Maior que 5." : "Menor que 5."); // Expressão sendo tratada pelo writeline e ja impressa de acordo com o condicional

            #endregion



        Console.WriteLine("Pressione qualquer tecla para fechar a aplicação...");
        Console.ReadKey();
        }
    }
}
