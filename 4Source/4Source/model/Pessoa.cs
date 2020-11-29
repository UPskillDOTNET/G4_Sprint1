using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;

namespace _4Source
{
    [Serializable()]
    public class Pessoa //: IComparer
    {
        public string nome;
        public string nif;
        public DateTime dataNascimento;

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

        }

        public override string ToString()
        {
            return "NIF: " + nif + "\n Nome: " + nome + "\n Data de nascimento: " + dataNascimento.ToString();
        }

        private static bool ValidarNome(string nome)
        {
            Regex regex = new Regex("^[a-zA-Z]{3,24}$", RegexOptions.IgnoreCase);
            Match m = regex.Match(nome);

            if (!m.Success)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        private static bool ValidarNif(string nif)
        {
            Regex regex = new Regex("^\\d{9}$", RegexOptions.IgnoreCase);
            Match m = regex.Match(nif);

            if (!m.Success)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool ValidarAno(DateTime ano)
        {
            if (ano.Year > DateTime.Now.Year)
            {
                return false;
            }
            return true;

        }

        //public int Compare(object x, object y)
        //{
        //    return ((new CaseInsensitiveComparer()).Compare(((Pessoa)y).Nif, ((Pessoa)x).Nif));
        //}

        //public class CompararIdade : IComparer
        //{
        //    public int Compare(object x, object y)
        //    {
        //        if (((Pessoa)x).dataNascimento < ((Pessoa)x).dataNascimento)
        //            return -1;
        //        if (((Pessoa)x).dataNascimento > ((Pessoa)x).dataNascimento)
        //            return 1;
        //        return 0;
        //    }
        //}

        //public class CompararNome : IComparer
        //{
        //    public int Compare(object x, object y)
        //    {

        //        return ((new CaseInsensitiveComparer()).Compare(((Pessoa)y).Nome, ((Pessoa)x).Nome));
        //    }
        //}
    }
}
