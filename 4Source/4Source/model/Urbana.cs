using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    [Serializable()]
    class Urbana : IClassificacao
    {
        double area;
        
        int valorBase;
        double indiceCont;
        double areaConst;
        DateTime dataConst;
        string tipologia;



        public Urbana()
        {

        }

        public Urbana(string tipologia, double areaConst, DateTime dataConst)
        {
            this.tipologia = tipologia;
            this.areaConst = areaConst;
            this.dataConst = dataConst;
        }

        public double CalcIMI()
        {
            double IMI = indiceCont * valorBase + (areaConst / area * 0.05);
            return IMI;
        }

        public string GetClassificacao()
        {
            return "Urbana" + "\n Tipo: " + tipologia +  "\n Area de construção: " + areaConst + "\n Data de construção " + dataConst;
        }
    
    }
}
