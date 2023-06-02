using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    abstract class Veiculo
    {
        public string Cor { get; set; }
        public string Marca { get; set; }


        public abstract void Acelerar();
        //posso implementar de forma abstrata.
        //obrigando cada classe fazer sua instanciação de forma diferente
        //Console.WriteLine("Acelerando!");
        // não tem comportamendo definifo

        public abstract void Parar();
        //{
        //    Console.WriteLine("Parando!");
        //}
        // não tem comportamendo definifo
    }
}
