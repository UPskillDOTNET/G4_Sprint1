using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    class Circular : IForma
    {
        double area;
        double raio;
        public double CalcArea()
        {
            double area = raio * Math.PI;
            return area;
            }


    }
}
