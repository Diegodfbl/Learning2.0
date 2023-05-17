using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Metodos m = new Metodos();

            #region OutrasAulas
            //m.Cumprimentar();
            //m.Somar(17, 23);
            //m.Apresentar("Diego F", 31);


            //int valor1 = 100;
            //int valor2 = 100;

            //m.AumentaValor(valor1);
            //m.AumentaRef(ref valor2);
            //Console.WriteLine("O valor 1 é "+ valor1);
            //Console.WriteLine("O valor 2 é "+ valor2);
            #endregion

            #region RETURN

            //string nomeCompleto = m.MontaNome("Diego", "Lima");
            //int CodChar = m.CodChar('D');
            //double PI = m.ValorPI();

            //Console.WriteLine(nomeCompleto);
            //Console.WriteLine(CodChar);
            //Console.WriteLine(PI);
            #endregion

            //método Cumprimentar tem 3 assinaturas diferentes e funcionais. SOBRECARGA DE MÉTODOS
            m.Cumprimentar();
            m.Cumprimentar("Diego");
            m.Cumprimentar("Diego", 15);

            bool res1 = m.Comparar(100, 25 * 4);
            bool res2 = m.Comparar("Diego", "DIEGO");
            
            Console.WriteLine(res1);
            Console.WriteLine(res2);


            Console.ReadKey();
        }
    }
}
