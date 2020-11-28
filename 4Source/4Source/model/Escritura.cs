using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source {
    [Serializable()]
    public class Escritura : Terreno {

        int num;
        DateTime data;
        

        public Escritura(int id, double indiceCont, string forma, double area, double imi, int num, DateTime data) : base(id, indiceCont, forma, area, imi) {

            this.num = num;
            this.data = data;

        }
        public int Num   // property
        {
            get { return num; }   // get method
            set { num = value; }
        }

        public DateTime Data {
            get { return data; }
            set { data = value; }
        }



    }
}
