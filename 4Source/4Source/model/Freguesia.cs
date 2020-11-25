using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _4Source
{
    public class Freguesia
    {
        string nome { get; set; }
        ArrayList terrenoList;

        public Freguesia(string nome)
        {
            this.nome = nome;
            terrenoList = new ArrayList();
        }

        //public void AddToList(Terreno.id)
        //{
            //terrenoList.Add(Terreno.id);
        //}
    }
}
