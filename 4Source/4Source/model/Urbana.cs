﻿using System;
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
        int valorBase = 1;
        double areaConst;
        double indiceCont;
        DateTime dataConst;
        string tipologia;

        public Urbana()
        {

        }

        public Urbana(double indiceCont, string tipologia, double areaConst, DateTime dataConst, double area)
        {
            this.indiceCont = indiceCont;
            this.tipologia = tipologia;
            this.areaConst = areaConst;
            this.dataConst = dataConst;
            this.area = area;
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
        public double GetIndiceCont()
        {
            return indiceCont;
        }
    }
}
