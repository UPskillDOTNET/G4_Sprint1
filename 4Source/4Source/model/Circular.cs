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
        public string forma = "Circular";
        double raio;
        public double CalcArea()
        {
            double area = raio * Math.PI;
            return area;
            }


    }
}
