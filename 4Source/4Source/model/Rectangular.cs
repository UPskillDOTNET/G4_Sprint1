using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    class Rectangular : Forma
    {
        private double area;
        public double all_area
        {
            get => area;
            set => area = Convert.ToDouble(Console.ReadLine());
        }

    }

}
