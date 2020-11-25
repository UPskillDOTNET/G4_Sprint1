using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    class Classificacao
    {
        string desc { get; set; }
        double areaConst { get; set; }
        DateTime dataConst { get; set; }

        public Classificacao(string desc, double areaConst, DateTime dataConst) 
        {
            this.desc = desc;
            this.areaConst = areaConst;
            this.dataConst = dataConst;
        }

        public Classificacao() {
            this.desc = "Lorem ipsilum";
            this.areaConst = 5000;
            this.dataConst = new DateTime(1970, 1, 1);
        }
    }
}
