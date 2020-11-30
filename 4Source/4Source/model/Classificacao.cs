using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    public interface IClassificacao
    {
       double CalcIMI();
       double GetIndiceCont();
       string GetClassificacao();
        string GetUso();
    }
}
