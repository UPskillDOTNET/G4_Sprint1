using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    class Industrial : IClassificacao
    {
        string classificacao = "Industrial";
        double area;
        string desc { get; set; }
        int valorBase { get;}
        double indiceCont { get;}
        double areaConst { get; set; }
        string dataConst { get; set; }
        string dataInsp { get; set; }
        string descInsp { get; set; }
        string tipologia { get; set; }


        public double CalcIMI()
        {
            double IMI = indiceCont*valorBase + (areaConst/area * 0.1);
            return IMI;
        }
    }
}
