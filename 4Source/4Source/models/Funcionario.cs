using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.models
{
    class Funcionario : Pessoa
    {
        private string cargo;
        private string numeroFunc;

        public string Cargo {
            get { return cargo; }
            set { cargo = value; }
        }

        public string NumeroFunc {
            get { return numeroFunc; }
            set { numeroFunc = value; }
        }

        public Funcionario(string cargo, string numeroFunc, string nome, string nif, DateTime dataNascimento) : base(nome, nif, dataNascimento)

        {
            this.cargo = cargo;
            this.numeroFunc = numeroFunc;

        }
    }   
}
