﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _4Source
{
    public class Freguesia
    {
        private string nome;
        private ArrayList terrenoList;

        public Freguesia(string nome)
        {
            this.nome = nome;
            this.terrenoList = new ArrayList();
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

        public ArrayList TerrenoList
        {
            get { return terrenoList; }
        } 

        public void AddToListFreg(Terreno t)
        {
            this.terrenoList.Add(t);
        }

        public Terreno PesquisarTerreno(int id)
        {
            Terreno terreno = GetTerrenoById(id);
            return terreno;
        }

        public Terreno EliminarTerreno(int id)
        {
            Terreno terreno = GetTerrenoById(id);
            if (terreno != null)
            {
                this.terrenoList.Remove(terreno);
            }
            else
            {
                throw new ElementoNaoExistenteException(nif + " Não existe");
            }
            return terreno;
        }

        public Terreno GetTerrenoById(int id)
        {

            foreach (Terreno t in TerrenoList)
            {
                if (t.Id == id)
                {
                    return t;
                }
            }
            return null;
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
