using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    [Serializable()]
    class Industrial : IClassificacao
    {
        
        double area;
        string desc; 
        int valorBase; 
        double indiceCont;
        double areaConst; 
        DateTime dataConst;
        DateTime dataInsp; 
        string descInsp; 
        string tipologia;





        public Industrial()
        {

        }

        public Industrial(string desc, string tipologia, int valorBase, double indiceCont, double areaConst, DateTime dataConst, DateTime dataInsp, string descInsp)
        {
            this.desc = desc;
            this.tipologia = tipologia;
            this.valorBase = valorBase;
            this.indiceCont = indiceCont;
            this.areaConst = areaConst;
            this.dataConst = dataConst;
            this.dataInsp = dataInsp;
            this.descInsp = descInsp;


        }




        public double CalcIMI()
        {
            double IMI = indiceCont*valorBase + (areaConst/area * 0.1);
            return IMI;
        }

        public string GetClassificacao()
        {
            return "Industrial" + desc + tipologia + areaConst + dataConst + dataInsp + descInsp;
        }
    }
}
