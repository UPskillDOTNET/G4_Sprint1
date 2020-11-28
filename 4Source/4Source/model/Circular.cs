using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    [Serializable()]
    class Circular : IForma
    {
        double area;
        double raio;

        public Circular(double area, double raio)
        {
            this.area = area;
            this.raio = raio;
        }

        public double CalcArea()
        {
            double area = raio * Math.PI;
            return area;
            }


    }
}
