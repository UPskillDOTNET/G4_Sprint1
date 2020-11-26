using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _4Source
{
    class Pessoa
    {
        private string nome;
        private long nif;
        private DateTime dataNascimento;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public long Nif
        {
            get { return nif; }
            set { nif = value; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public Pessoa(string nome, long nif, DateTime dataNascimento)
        {
            this.nome = nome;
            this.nif = nif;
            this.dataNascimento = dataNascimento;
        }

        //public Pessoa()
        //{
        //    this.nome = "John Wick";
        //    this.nif = "999999999";
        //    this.dataNascimento = new DateTime(1970, 1, 1);
        //

        public override string ToString()
        {
            return "NIF: " + nif + "\n Nome: " + nome + "\n Data de nascimento: " + dataNascimento.ToString();
        }

        private static bool ValidarNome(string nome)
        {
            Regex regex = new Regex ("^[a-zA-Z]{3,24}$", RegexOptions.IgnoreCase);
            Match m = regex.Match(nome);

            if (!m.Success)
            {
                return false;
            }
            else
            {
                return true;
            }

            //if (nome == null)
            //{
            //    return false;
            //}
            //else if (nome.Length <= 2)
            //{
            //    return false;
            //}
            //else if (typeof

            //}
        } 
    }
}
