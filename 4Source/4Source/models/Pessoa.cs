using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.models
{
    class Pessoa
    {
        private string nome;
        private string nif;
        private DateTime dataNascimento;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Nif
        {
            get { return nif; }
            set { nif = value; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public Pessoa(string nome, string nif, DateTime dataNascimento)
        {
            this.nome = nome;
            this.nif = nif;
            this.dataNascimento = dataNascimento;
        }

        public Pessoa()
        {
            this.nome = "John Wick";
            this.nif = "999999999";
            this.dataNascimento = new DateTime(1970, 1, 1);
        }
    }
}
