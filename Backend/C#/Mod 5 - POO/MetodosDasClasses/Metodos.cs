using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
        // Métodos Simples(SEM RETORNO E PARAMENTROS)
        public void Cumprimentar()
        {
            Console.WriteLine("Olá, seja bem vindo.");
        }

        // Métod com PARAMENTROS

        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma é: " + resultado);

        }


        public void Apresentar(string nome, int idade)
        { 
            Console.WriteLine("Meu nome é "+ nome + " e tenho " + idade +" anos");
        }

        // Passagem de paramentros por valor
        public void AumentaValor(int valor)
        {   
            valor += 10;
            Console.WriteLine("O valor final (por valor) é :" +valor);
        }
        
        
        // Passagem de paramentros por referencia
        public void AumentaRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("O valor final (por referencia) é :" + valor);
        }




        // Métodos com RETORNO de valores
        // o RETURN, faz com o que o conteúdo que retorna fique perdido no limbo. por isso no PROGRAM.CS deve se colocar
        // conteúdo numa variável, e esta ser impressa na tela, ou tratada de alguma forma.

        public string MontaNome(string nome, string sobrenome)
        {
            // string nomeCompleto = nome + " " + sobrenome;
            return nome + " " + sobrenome;
        }

        public int CodChar(char Caracter)
        {
            //int Cod = (int)Caracter;
            return Caracter;
        }

        public double ValorPI()
        { 
            return 3.1415;
        }


        // SOBRECARGA de MÉTODOS
        // posso ter o mesmo método, porém o que tem que ser diferente pra não dar erro é a passagem de atributos
        public void Cumprimentar(string nome)
        {
            Console.WriteLine("Olá, " + nome + " seja bem vindo.");
        }

        public void Cumprimentar(string nome, int hora)
        {
            string msg = hora < 12 ? "BOM DIA " + nome : "BOA TARDE " + nome;
            Console.WriteLine(msg);
        }

        public bool Comparar(int num1, int num2)
        {

            return num1 == num2;
        }
        public bool Comparar(string  txt1, string txt2)
        {

            return txt1 == txt2;
        }
    }
}
