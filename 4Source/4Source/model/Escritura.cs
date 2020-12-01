using _4Source.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source {
    [Serializable()]
    public class Escritura {

        int num;
        DateTime data;
        Terreno terreno;
        List<Proprietario> proprietariosList;

        public Escritura()
        {
            this.ProprietariosList = new List<Proprietario>();
        }

        public Escritura(int num, DateTime data, Terreno terreno, List<Proprietario> proprietariosList) {

            this.Num = num;
            this.Data = data;
            this.Terreno = terreno;
            this.ProprietariosList = new List<Proprietario>();
        }
    
        public Terreno Terreno { get => terreno; set => terreno = value; }
        public List<Proprietario> ProprietariosList { get => proprietariosList; set => proprietariosList = value; }
        public DateTime Data { get => data; set => data = value; }
        public int Num { get => num; set => num = value; }

        public override string ToString()
        {
            //To be done
            //proprietariosList.ForEach(Console.WriteLine);
            return String.Format("Número de escritura: {0} Data: {1} Proprietarios", Num, Data);
            
        }
    }
}
