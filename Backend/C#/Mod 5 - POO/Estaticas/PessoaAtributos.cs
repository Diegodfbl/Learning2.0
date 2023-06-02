using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estaticas
{
    partial class Pessoa 
    //partial indica que são classes diferentes do mesmo name space
    // pode ter membros estaticos e comuns
    {
        public static int maioridade = 18; //membro estático com a definição do campo

        public string nome; // não estático
        public int idade; // não estático

    }
}
