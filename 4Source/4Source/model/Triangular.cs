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
        private double area;
        private double largura;
        private double comprimento;

        public Triangular()
        {

        }

        public Triangular(double area, double largura, double comprimento)
        {
            this.area = area;
            this.largura = largura;
            this.comprimento = comprimento;
        }

        public double Area { get => area; set => area = value; }
        public double Largura { get => largura; set => largura = value; }
        public double Comprimento { get => comprimento; set => comprimento = value; }

        public double CalcArea()
        {
            double area = Largura * Comprimento;
            return area;
        }


    }

}

