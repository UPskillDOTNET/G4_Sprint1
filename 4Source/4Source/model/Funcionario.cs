using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Source;
using System.Text.RegularExpressions;


namespace _4Source
{
    class Funcionario : Pessoa
    {
        private string cargo;
        private string numeroFunc;

        public Funcionario(string cargo, string numeroFunc, string nome, string nif, DateTime dataNascimento) : base(nome, nif, dataNascimento) {
            this.cargo = cargo;
            this.numeroFunc = numeroFunc;

        }

        public override string ToString() {
            return base.ToString() + "\nnumero: " + numeroFunc + "\ncargo='" + cargo;
        }

        public string Cargo {
            get { return cargo; }
            set { cargo = value; }
        }

        private static bool ValidarNumeroFunc (string numeroFunc) {
            Regex regex = new Regex("^[1-9]\\d*$", RegexOptions.IgnoreCase);
            Match m = regex.Match(numeroFunc);

            if (!m.Success) {
                return false;
            } else {
                return true;
            }
        }

    }   
}

