using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    class Industrial : Classificacao
    {
        string desc { get; set; }
        int valorBase { get;}
        double indiceCont { get;}
        double areaConst { get; set; }
        string dataConst { get; set; }
        string dataInsp { get; set; }
        string descInsp { get; set; }
        string tipologia { get; set; }


        public double clacIMI()
        {
            double IMI = indiceCont*valorBase + (areaConst/area * 0.1);
            return IMI;
        }
    }
}
