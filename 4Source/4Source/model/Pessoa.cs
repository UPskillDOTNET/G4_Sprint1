using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    class Pessoa
    {
        string nome;
        string nif;
        DateTime dataNascimento;

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
