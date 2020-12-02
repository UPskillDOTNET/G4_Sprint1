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

        public double IndiceCont { get => indiceCont; set => indiceCont = value; }
        public double Area { get => area; set => area = value; }
        public string Desc { get => desc; set => desc = value; }
        public int ValorBase { get => valorBase; set => valorBase = value; }
        public double AreaConst { get => areaConst; set => areaConst = value; }
        public DateTime DataConst { get => dataConst; set => dataConst = value; }
        public DateTime DataInsp { get => dataInsp; set => dataInsp = value; }
        public string DescInsp { get => descInsp; set => descInsp = value; }
        public string Tipologia { get => tipologia; set => tipologia = value; }

        public Industrial()
        {

        }

        public Industrial(double indiceCont,string desc, string tipologia, double areaConst, DateTime dataConst, DateTime dataInsp, string descInsp, double area)
        {
            this.Desc = desc;
            this.Tipologia = tipologia;
            this.AreaConst = areaConst;
            this.DataConst = dataConst;
            this.DataInsp = dataInsp;
            this.DescInsp = descInsp;
            this.Area = area;
        }

        public override string ToString()
        {

            return "Industrial\nPrincipal atividade: " + desc + "\nTipo: " + tipologia + "\nArea de construção: " + areaConst + "\nData de construção: " + dataConst.ToString("dd/MM/yyyy") + "\n\nUltima Inspeção\n" + "Data: " + dataInsp.ToString("dd/MM/yyyy") + "\nDescrição: " + descInsp;
        }

        public double CalcIMI()
        {
            double IMI = IndiceCont*ValorBase + (AreaConst/Area * 0.1);
            return IMI;
        }

        public string GetClassificacao()
        {
            return "Industrial";
        }
        public double GetIndiceCont()
        {
            return IndiceCont;
        }
        public string GetUso()
        {
            return this.Desc;
        }

        public DateTime GetData()
        {
            return this.dataInsp;
        }
    }
}
