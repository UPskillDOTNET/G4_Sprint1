using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.models
{
    public class Terreno
    {
        int id;
        double indiceCont;
        double area;
        double imi;
        

        public Terreno(int id, double indiceCont, double area, double imi)
        {
            this.id = id;
            this.indiceCont = indiceCont;
            this.area = area;
            this.imi = imi;
        }
    }
}


