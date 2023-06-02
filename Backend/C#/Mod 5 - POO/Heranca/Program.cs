using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    // permite as classes herde metodos e atribus de outra classe

    //  C L A S S E   A B S T R A T A
    // serve apenas como classe base para servir de suporte para herança


    // C L A S S E  S E L E D
    // Classe usada para criar objetos(instanciar), pode ter herança, mas  não ser herdada
    class Program
    {
        static void Main(string[] args)
        {
            #region 1a PARTE

            //Carro c = new Carro();
            //Bicilceta b = new Bicilceta();
            //// Veiculo v = new Veiculo();
            //// não da pra instanciar objeto dessa classe ABSTRATA



            //c.Marca = "VW ";
            //c.Cor = "Preto";
            //c.LigarMotor();
            //c.Acelerar();
            //c.Parar();
            //Console.WriteLine("O carro " + c.Marca + c.Cor +" parou");
            //Console.WriteLine();


            //b.Marca = "CALOI ";
            //b.Cor = "Brnaca";
            //b.Pedalar();
            //b.Acelerar();
            //b.Parar();
            //Console.WriteLine("A bike " + b.Marca + b.Cor + " parou");
            #endregion

            
            Humano a = new Humano();
            Pessoa b = new Pessoa();
            Homem c = new Homem();

            Console.WriteLine("\nHumano");
            a.Olhos();
            a.Cabelos();

            Console.WriteLine("\nPessoa");
            b.Olhos();
            b.Cabelos();

            Console.WriteLine("\nHomem");
            c.Olhos();
            Console.WriteLine("Mostra que a Classe Homem herdou o 'Pessoa.Olhos' da Pessoa sem alteração, pois era sealed");
            c.Cabelos();



            Console.ReadKey();
        }
    }
}
