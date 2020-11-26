using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    class Rectangular : IForma
    {
        double area;
        public string forma = "Retangular";
        double largura;
        double altura;

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
