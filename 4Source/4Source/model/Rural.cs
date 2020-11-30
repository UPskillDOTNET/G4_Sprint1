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


        private string descUso;
        int valorBase = 1;
        double indiceCont;

        public string DescUso { get => descUso; set => descUso = value; }

        public Rural()
        {

        }

        public Rural(double indiceCont, string descUso)
        {
            this.indiceCont = indiceCont;
            this.DescUso = descUso;
          
        }

        public override string ToString()
        {
            return "Rural\n " + "Pricipal atividade: " + DescUso;
        }


        public double CalcIMI()
        {
            double IMI = indiceCont * valorBase;
            return IMI;
        }

        public string GetClassificacao()
        {
            return "Rural";
        }
        public double GetIndiceCont()
        {
            return indiceCont;
        }
        public string GetUso()
        {
            return this.descUso;
        }
    }
  }

