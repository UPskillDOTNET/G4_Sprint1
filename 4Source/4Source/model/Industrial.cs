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

        public Industrial(string desc, string tipologia, double areaConst, DateTime dataConst, DateTime dataInsp, string descInsp)
        {
            this.desc = desc;
            this.tipologia = tipologia;
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
            return "Industrial\n Principal atividade: "  + desc + "\n Tipo: " + tipologia + "\n Area de construção: " + areaConst + "\n Data de construção: " + dataConst +  "\n\nUltima Ispeção\n"+ " Data: " + dataInsp + "\n Descrição: " + descInsp;
        }
    }
}
