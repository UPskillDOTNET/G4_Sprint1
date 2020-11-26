using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _4Source {
    class Autarquia {
        private string nome;
        private ArrayList pessoas;
        private ArrayList freguesias;
        private int valorbase;

        public Autarquia(string nome, int valorbase) {
            this.nome = nome;
            this.valorbase = valorbase;
            this.pessoas = new ArrayList();
            this.freguesias = new ArrayList();
        }
    }
}