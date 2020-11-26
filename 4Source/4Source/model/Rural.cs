using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    class Rural : IClassificacao
    {
        string classificacao = "Rural";
        string descUso;

        public string DescUso { get => descUso; set => descUso = value; }
        int valorBase { get => valorBase; }
        double indiceCont { get => indiceCont; }


        public double CalcIMI()
        {
            double IMI = indiceCont * valorBase;
            return IMI;
        }
    }
  }

