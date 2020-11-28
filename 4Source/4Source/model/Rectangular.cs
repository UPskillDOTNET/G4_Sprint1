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
        double area;
        double largura;
        double altura;

        public Rectangular(double area, double largura, double altura)
        {
            this.area = area;
            this.largura = largura;
            this.altura = altura;
        }

        public double Area { get => area; set => area = value; }
        public double Largura { get => largura; set => largura = value; }
        public double Altura { get => altura; set => altura = value; }

        public double CalcArea()
        {
            double area = Largura * Altura / 2;
            return area;
        }

    }

}
