using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _4Source.models
{
    public class Freguesia
    {
        private string nome { get; set; }
        private ArrayList terrenoList;

        public Freguesia(string nome)
        {
            this.nome = nome;
            terrenoList = new ArrayList();
        }

        public override string ToString()
        {
            Terreno t;
            string str = "Nome: " + this.nome + "\n";
            foreach (Object obj in this.terrenoList)
            {
                t = (Terreno)obj;
                str += "\t" + t.ToString() + "\n";
            }


            return str;
        }

        public string Nome   // property
        {
            get { return nome; }
            set
            {
                if (NomeValido(value))
                {
                    this.nome = value;
                }
                else
                {
                    throw new NomeInvalidoException(value + ": Nome inválido");
                }
            }
        }

        public void AddToList(Terreno t)
        {
            this.terrenoList.Add(t);
        }
        private bool NomeValido(string nome)
        {
            if (nome == null)
            {
                return false;
            }
            if (nome.Length < 3)
            {
                return false;
            }
            for (int i = 0; i < nome.Length; i++)
            {
                if (nome[i] >= '0' && nome[i] <= '9')

                    return false;
            }
            return true;
        }
    }
}
