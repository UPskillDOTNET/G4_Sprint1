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
        int valorBase;
        double indiceCont;



        public Rural()
        {

        }

        public Rural(string descUso)
        {
            this.descUso = descUso;
          
        }


        public double CalcIMI()
        {
            double IMI = indiceCont * valorBase;
            return IMI;
        }

        public string GetClassificacao()
        {
            return "Rural " + "com pricipal atividade "  + descUso;
        }
    }
  }

