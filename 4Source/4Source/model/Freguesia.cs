using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _4Source
{
    class Freguesia
    {
        string nome { get; set; }
        ArrayList terreno;

        public Freguesia(string nome)
        {
            this.nome = nome;
            terreno = new ArrayList();
        }
    }
}
