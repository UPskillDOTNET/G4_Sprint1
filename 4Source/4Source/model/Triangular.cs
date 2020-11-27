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
        public string forma = "Triangular";
        private double largura, comprimento;

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

