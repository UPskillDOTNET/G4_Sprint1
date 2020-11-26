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
        double largura;
        double altura;
        
        public double CalcArea()
        {
            double area = largura * altura / 2;
            return area;
        }

    }

}
