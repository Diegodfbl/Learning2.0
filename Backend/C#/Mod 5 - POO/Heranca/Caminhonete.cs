using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    sealed class Caminhonete : Carro // herança multipla. Herda tudo de carro, e herda tudo de veículo
    {
        public bool CabineExtendida { get; set; }
    }
}
