using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    class Urbana : IClassificacao
    {
        string classificacao = "Urbana";
        double area;
        string desc;
        int valorBase;
        double indiceCont;
        double areaConst;
        string dataConst;
        string tipologia;

        public string Tipologia { get => tipologia; set => tipologia = value; }
        public string DataConst { get => dataConst; set => dataConst = value; }
        public double AreaConst { get => areaConst; set => areaConst = value; }
        public double IndiceCont { get => indiceCont; set => indiceCont = value; }
        public int ValorBase { get => valorBase; set => valorBase = value; }
        public string Desc { get => desc; set => desc = value; }
        public double Area { get => area; set => area = value; }

        
        public double CalcIMI()
        {
            double IMI = IndiceCont * ValorBase + (AreaConst / Area * 0.05);
            return IMI;
        }
    }
}
