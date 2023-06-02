using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste t = new Teste();
            Homem h = new Homem();
            Humano hu = new Humano();

            //t.nome = "";
            // nome é privado.

            t.MetodoPublic();
            
            //t.MetodoPrivate();
            // este método é privado.

            h.MetodoPublic();
            //hu.nomeh = "";
            // nomeh é protected, acessivel somente na classe de origem.
            h.Metodo();
            h.idade = 18;
        }
    }
}
