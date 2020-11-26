using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    public class Terreno
    {
        private int id;
        private double indiceCont;
        private double area;
        private double imi;


        public Terreno(int id, double indiceCont, double area, double imi)
        {
            this.id = id;
            this.indiceCont = indiceCont;
            this.area = area;
            this.imi = imi;
        }
        public int Id   // property
        {
            get { return id; }
            set { id = value; }
        }
        public double IndiceCont   // property
        {
            get { return indiceCont; }
            set { indiceCont = value; }
        }
        public int Id   // property
        {
            get { return id; }
            set { id = value; }
        }
    }
}


