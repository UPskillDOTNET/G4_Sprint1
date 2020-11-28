using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    [Serializable()]
    class Triangular : IForma
    {
        private double largura;
        private double comprimento;

        public Triangular()
        {

        }

        public Triangular(double largura, double comprimento)
        {
            this.largura = largura;
            this.comprimento = comprimento;
        }


        public double CalcArea()
        {
            return largura * comprimento / 2;            
        }

        public string GetForma()
        {
            return "Triangular";
        }
    }

}

