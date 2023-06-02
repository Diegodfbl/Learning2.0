using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    sealed class Bicilceta : Veiculo // para mostrar que bicicleta vai herdade de veiculo
    {
         public void Pedalar()
        {
            Console.WriteLine("Pedalando!");
        }

        public override void Acelerar()
        // esta sendo sbrerscrito no método abstrato.
        {
            Console.WriteLine("Acelerando a Bicicleta");
        }

        public override void Parar()
        {
            Console.WriteLine("Parando a Bicicleta");

        }

    }

}
