using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    class Classificacao
    {
        string desc;
        double areaConst;
        string dataConst;

        public Classificacao(string desc, double areaConst, string dataConst) {
            this.desc = desc;
            this.areaConst = areaConst;
            this.dataConst = dataConst;
        }
    }
}
