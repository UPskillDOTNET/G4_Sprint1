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
        double raio;

        public Circular()
        {

        }

        public Circular(double raio)
        {
            this.raio = raio;
        }

        public double CalcArea()
        {
            return raio * raio * Math.PI;
        }

        public string GetForma()
        {
            return "circular";
        }
    }
}
