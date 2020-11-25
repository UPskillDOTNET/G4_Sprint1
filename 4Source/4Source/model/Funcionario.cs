using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    class Funcionario : Pessoa
    {
        string cargo;
        string numeroFunc;

        public Funcionario(string cargo, string numeroFunc, string nome, string nif, DateTime dataNascimento) : base(nome, nif, dataNascimento)

        {
            
        }
    }   
}
