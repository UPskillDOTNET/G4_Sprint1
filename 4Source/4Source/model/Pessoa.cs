using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;
using System.Globalization;

namespace _4Source
{
    [Serializable()]
    public class Pessoa //: IComparer
    {
        private string nome;
        private string nif;
        private DateTime dataNascimento;
        private int terrenosOwned;

      
        public string Nome { get => nome; set => nome = value; }
        public string Nif { get => nif; set => nif = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public int TerrenosOwned { get => terrenosOwned; set => terrenosOwned = value; }

        public Pessoa(string nome, string nif, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Nif = nif;
            this.DataNascimento = dataNascimento.Date;
            this.terrenosOwned = 0;
        }

        public Pessoa()
        {

        }

        public override string ToString()
        {
            return "NIF: " + Nif + "\nNome: " + Nome + "\nData de nascimento: " + DataNascimento.ToString("dd/MM/yyyy");
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


        //public List<Pessoa> ListarIdade() 
        //{
            
        //    return SortedList;
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
