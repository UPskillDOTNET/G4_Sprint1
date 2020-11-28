using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.model
{
    class Proprietario : Pessoa 
    {
        double percentagem;
        ArrayList listaTerrenos;

        public Proprietario(double percentagem)
        {
            this.Percentagem = percentagem;
            this.ListaTerrenos = new ArrayList();
        }

        public Proprietario()
        {

        }

        public double Percentagem { get => percentagem; set => percentagem = value; }
        public ArrayList ListaTerrenos { get => listaTerrenos; set => listaTerrenos = value; }
    }
}
