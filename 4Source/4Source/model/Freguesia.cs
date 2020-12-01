﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace _4Source
{
    [Serializable()]
    public class Freguesia //: IComparer
    {
        private string nome;
        private List<Terreno> terrenoList;
        private double dimensaoTotal;
        private double contriAuto;


        public Freguesia(string nome)
        {
            this.Nome = nome;
            this.terrenoList = new List<Terreno>();
        }

        public Freguesia()
        {
            this.terrenoList = new List<Terreno>();
        }
        
        public override string ToString()
        {
            return "Nome da freguesia: " + Nome;
        }

 
        public List<Terreno> TerrenoList { get => terrenoList; set => terrenoList = value; }
        public double ContriAuttotal { get; set; }
        public string Nome { get => nome; set => nome = value; }
        public double DimensaoTotal { get => dimensaoTotal; set => dimensaoTotal = value; }
        public double ContriAuto { get => contriAuto; set => contriAuto = value; }

        public void RegistarTerreno(Terreno t)
        {

            Terreno temp = GetTerrenoById(t.Id);
            if (temp == null)
            {
                    this.terrenoList.Add(t);
            }else
            {
                throw new IdDuplicadoException(t.ToString() + "Id já existente");
            }
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
                throw new ElementoNaoExistenteException(id + " Não existe");
            }
            Console.WriteLine("O terreno abaixo foi eliminado");
            return terreno;
        }

        public List<Terreno> ObterTodosTerrenos()
        {
            return this.TerrenoList;
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

        //private static bool ValidarNome(string nome)
        //{
        //    Regex regex = new Regex("^[a-zA-Z]{3,24}$", RegexOptions.IgnoreCase);
        //    Match m = regex.Match(nome);

        //    if (!m.Success)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }

        //}
    }
}
