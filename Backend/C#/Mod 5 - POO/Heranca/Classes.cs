using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Humano
    {
        // membro sealed em método ou propriedade - impede que seja substituidos os metodos nas heranças

        public virtual void Olhos()
        {
            Console.WriteLine("Humano.Olhos");
        }

        public virtual void Cabelos()
        {
            Console.WriteLine("Humano.Cabelos");
        }
    }
    class Pessoa : Humano
    {
        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa.Olhos");
        }

        public override void Cabelos()
        {
            Console.WriteLine("Pessoa.Cabelos");
        }
    }


    class Homem : Pessoa
        {
            //public override void Olhos()
            //{
            //    Console.WriteLine("Homem.Olhos");
            //}
            // se na classe Pessoa, um membro for sealed
            // ele pode ser herdado mas não modificado


            public override void Cabelos()
            {
                Console.WriteLine("Homem.Cabelos");
            }
        }
    }

