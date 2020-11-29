using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source {
    [Serializable()]
    public class Escritura {

        int num;
        DateTime data;
        Terreno terreno;
        ArrayList proprietariosList;

        public Escritura()
        {
            this.ProprietariosList = new ArrayList();
        }

        public Escritura(int num, DateTime data, Terreno terreno, ArrayList proprietariosList) {

            this.Num = num;
            this.Data = data;
            this.Terreno = terreno;
            this.ProprietariosList = new ArrayList();
        }
    
        public Terreno Terreno { get => terreno; set => terreno = value; }
        public ArrayList ProprietariosList { get => proprietariosList; set => proprietariosList = value; }
        public DateTime Data { get => data; set => data = value; }
        public int Num { get => num; set => num = value; }

        public override string ToString()
        {
            return String.Format("Número de escritura: {0} Data: {1}", Num, Data);
        }
    }
}
