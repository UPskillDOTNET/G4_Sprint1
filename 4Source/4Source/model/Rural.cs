using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    [Serializable()]
    class Rural : IClassificacao
    {
        

        public string descUso;
        int valorBase = 1;
        double indiceCont;



        public Rural()
        {

        }

        public Rural(double indiceCont, string descUso)
        {
            this.indiceCont = indiceCont;
            this.descUso = descUso;
          
        }


        public double CalcIMI()
        {
            double IMI = indiceCont * valorBase;
            return IMI;
        }

        public string GetClassificacao()
        {
            return "Rural\n " + "Pricipal atividade: "  + descUso;
        }
        public double GetIndiceCont()
        {
            return indiceCont;
        }
    }
  }

