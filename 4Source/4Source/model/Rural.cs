using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    class Rural : Classificacao
    {
        string descUso { get; set; }
        int valorBase { get; }
        double indiceCont { get; }


        public double clacIMI()
        {
            double IMI = indiceCont * valorBase;
            return IMI;
        }
    }
  }

