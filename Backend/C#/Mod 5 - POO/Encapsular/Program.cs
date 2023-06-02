using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ENCAPSULAMENTO = significa separar o código partes o mais isolado possivel, processo de ocultar ou esconder os membros de uma classe ao acesso exterior usando modificaroes de acesso.
            
            
            Conta c = new Conta();
            c.Cliente = "Diego";
            //c.Saldo = 3580.56;


            // ######################  O P E R A Ç Ã O  D E  D E P Ó S I T O  ###########################
            double valor = 100;
            c.Depositar(valor);


            // ######################  O P E R A Ç Ã O  D E  S A C A R  ###########################

            double valor2 = 50;
            c.Sacar(valor2);


            // ######################  S A L D O  A T U A L ###########################

            Console.WriteLine("Cliente: " + c.Cliente);
            Console.WriteLine("Saldo atual: " + c.Saldo);

            Console.ReadKey();
        }
    }
}
