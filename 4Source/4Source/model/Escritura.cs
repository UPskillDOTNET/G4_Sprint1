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
        public DateTime Data { get => data; set => data = value; }
        public int Num { get => num; set => num = value; }
        public List<Proprietario> ProprietariosList { get => proprietariosList; set => proprietariosList = value; }

        public override string ToString()
        {

            return String.Format("Número de escritura: {0}\nData: {1}", Num, Data.ToString("dd/MM/yyyy"));

        }


        //public Proprietario GetProprietarioByNif(string nif)
        //{

        //        foreach (Proprietario p in ProprietariosList)
        //        {
        //        if (p.Nif == nif)
        //        {
        //            return p;
        //        }
        //    }
        //    return null;
        //}

        //public Proprietario GetProprietarioByNif(string nif)
        //{
        //    Proprietario p = null;
        //    foreach (Object obj in this.ProprietariosList)
        //    {
        //        if (obj.GetType() == typeof(Proprietario))
        //        {
        //            p = (Proprietario)obj;
        //            if (p.Nif == nif)
        //            {
        //                return p;
        //            }
        //        }
        //    }
        //    return null;
        //}

        public static void GetProprietarios(List<Proprietario> proprietarioList)
        {
            for (int i = 0; i < proprietarioList.Count; i++)
            {
                Console.WriteLine(proprietarioList[i]);
            }
        }
    }
    }
