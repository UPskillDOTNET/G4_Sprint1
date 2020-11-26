using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    class Escritura : Terreno
    {
        
        int num { get; set;  }
        DateTime data { get; set; }

        public Escritura(int id, double indiceCont, string forma, double area, double imi, int num, DateTime data) : base(id, indiceCont, forma, area, imi)
        {
        
        this.num = num;
        this.data = data;
        
        }
    }   
}
