using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int anonasc;
        public int idade;


        // método construtor será sempre executado na instanciação do objeto
        // sempre tem que ter com o Mesmo nome da CLASSE
        public Pessoa()
        {
            nome = "DESCONHECIDO";
            sobrenome = "VAZIO";
            anonasc = 0;
            idade = 0;

        }
        // sobrecarga com assinatura diferente.
        public Pessoa(string nome, string sobrenome, int anonasc)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anonasc = anonasc;
            idade = Idade();

        }
        // sobrecarga com assinatura diferente. Sem o int idade
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.anonasc = 2005;
            idade = Idade();

        }


        //método para calcular quantos anos. 
        private int Idade()
        {
            return 2023 - anonasc;

        }

    }
}
