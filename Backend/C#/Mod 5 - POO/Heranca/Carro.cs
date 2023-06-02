using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Carro : Veiculo // para mostrar que bicicleta vai herdade de veiculo
    {
        public string VelocidadeMax { get; set; }

        public void LigarMotor()
        {
            Console.WriteLine("Carro Ligado!");
        }

        public override void Acelerar() // esta sendo sbrerscrito no método abstrato
        {
            Console.WriteLine("Acelerando o  Carro");
        }

        public override void Parar()
        {
            Console.WriteLine("Parando o Carro");

        }
    }
}
