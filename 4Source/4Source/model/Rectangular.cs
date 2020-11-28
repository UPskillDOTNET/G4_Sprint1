using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    [Serializable()]
    class Rectangular : IForma
    {
        double largura;
        double comprimento;

        public Rectangular()
        {

        }

        public Rectangular(double largura, double comprimento)
        {
            this.largura = largura;
            this.comprimento = comprimento;
        }

        public double CalcArea()
        {
            return largura * comprimento;

        }
        public string GetForma()
        {
            return "Rectangular";
        }

    }

}
