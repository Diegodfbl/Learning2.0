﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDELEGATE
{
    internal class matematica
    {
        public void Somar(int n1, int n2)
        {
            Console.WriteLine($"A soma de {n1} + {n2} é = " + (n1 + n2));
        }

        public void Subtrair(int n1, int n2)
        {
            Console.WriteLine($"A subtração de {n1} - {n2} é = " + (n1 - n2));
        }
        public void Multiplicar(int n1, int n2)
        {
            Console.WriteLine($"A multiplicação de {n1} * {n2} é =  " + (n1 * n2));
        }
        public void Dividir(int n1, int n2)
        {
            Console.WriteLine($"A divisão de {n1} / {n2} é = " + (n1 / n2));
        }
    }
}
