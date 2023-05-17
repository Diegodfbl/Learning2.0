using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class acessar
    {
        string senha = "123456";

        public bool Login(string senha)
        {
            return this.senha == senha;    
        }
    }
}
