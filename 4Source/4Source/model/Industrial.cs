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
        double indiceCont;
        double area;
        string desc; 
        int valorBase = 10; 
        double areaConst; 
        DateTime dataConst;
        DateTime dataInsp; 
        string descInsp; 
        string tipologia;

        public Industrial()
        {

        }

        public Industrial(double indiceCont,string desc, string tipologia, double areaConst, DateTime dataConst, DateTime dataInsp, string descInsp, double area)
        {
            this.desc = desc;
            this.tipologia = tipologia;
            this.areaConst = areaConst;
            this.dataConst = dataConst;
            this.dataInsp = dataInsp;
            this.descInsp = descInsp;
            this.area = area;
        }

        public override string ToString()
        {
            return "Industrial\n Principal atividade: " + desc + "\n Tipo: " + tipologia + "\n Area de construção: " + areaConst + "\n Data de construção: " + dataConst.ToString("dd/MM/yyyy") + "\n\nUltima Ispeção\n" + " Data: " + dataInsp.ToString("dd/MM/yyyy") + "\n Descrição: " + descInsp;
        }
        public double CalcIMI()
        {
            //double area = terreno.Forma.CalcArea();
            double IMI = indiceCont*valorBase + (areaConst/area * 0.1);
            return IMI;
        }

        public string GetClassificacao()
        {
            return "Industrial";
        }
        public double GetIndiceCont()
        {
            return indiceCont;
        }
        public string GetUso()
        {
            return this.desc;
        }
    }
}
