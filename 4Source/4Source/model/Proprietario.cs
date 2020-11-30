using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.model
{


    [Serializable()]
    public class Proprietario : Pessoa 
    {
        double percentagem;
        List<Terreno> listaTerrenos;

        public Proprietario(double percentagem)
        {
            this.Percentagem = percentagem;
            this.ListaTerrenos = new List<Terreno>();
        }

        public Proprietario()
        {

        }

        public double Percentagem { get => percentagem; set => percentagem = value; }
        public List<Terreno> ListaTerrenos { get => listaTerrenos; set => listaTerrenos = value; }
    }
}
