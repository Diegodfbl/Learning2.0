using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDELEGATE
{
    internal class Program
    {
        delegate void Operacao(int num1, int num2);
        static void Main(string[] args)
        {
            matematica m = new matematica();

            Operacao contaSoma = null;
            Operacao contaSub = null;
            Operacao contaMult = null;
            Operacao contaDiv = null;

            contaSoma += m.Somar;
            contaSoma(20, 11);
            //Console.WriteLine(contaSoma);

            contaSub += m.Subtrair;
            contaSub(20, 12);
            //Console.WriteLine(contaSub);

            contaMult += m.Multiplicar;
            contaMult(20, 13);
           // Console.WriteLine(contaMult);

            contaDiv += m.Dividir;
            contaDiv(20, 4);
           // Console.WriteLine(contaDiv);

            Console.ReadKey();
        }
        
    }
}
