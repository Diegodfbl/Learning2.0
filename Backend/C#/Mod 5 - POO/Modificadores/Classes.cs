using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Teste
    {
        private string nome;
        //string privada, acessivel somente nesta classe
        //(priv. é particular somente dessa classe).

        public string sobrenome;
        //string publica, acessivel por qqr um.
        
        private void MetodoPrivate() { }
        // método privado a somente esta classe.

        public void MetodoPublic() { }
        // método publico acessivel por qqr um.
    }

    class Humano : Teste
    {
        protected string nomeh;
        // proctected significa que o objeto "nome" pode ser acessado por classes herdadas,
        // mas não pode ser instanciadas em outros ojetos 
        private string sobrenomeh;
        internal int idade;
        // membro do tipo interno pode ser acessado somente nesta aplicação.
        // visivel em todos as classes desta compilação.
    }

    class Homem : Humano
    {
        public void Metodo()
        {
            nomeh = "";
            //sobrenome = "";
        }    
    }
}
