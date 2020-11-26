using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.models
{
    class Escritura : Terreno
    {
        int num { get; set;  }
        DateTime data { get; set; }

        public Escritura(int id, double indiceCont, double area, double imi, int num, DateTime data) : base(id, indiceCont, area, imi)
        {
        
        this.num = num;
        this.data = data;
        
        }
    }   
}
