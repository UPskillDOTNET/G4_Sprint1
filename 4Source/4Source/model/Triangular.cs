using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    class Triangular : IForma
    {
        public double area;
        public string forma = "Triangular";
        private double largura, comprimento;
        
        
        public double CalcArea()
        {
            double area = largura * comprimento;
            return area;
        }


    }

}

