using System;
using System.Collections;
using _4Source;
using _4Source.persistencia;
using System.Collections.Generic;

namespace _4Source.controllers
{
    class RegistoTerrenoController
    {
        public static bool RegistarTerreno(string nomeFreguesia,Terreno terreno) {
            bool flag = true;
            try {
                Autarquia autarquia = Dados.CarregarDados();
                Freguesia freguesia = autarquia.GetFreguesiaByNome(nomeFreguesia);
                freguesia.RegistarTerreno(terreno);
                Dados.GuardarDados(autarquia);
            } catch (TerrenoDuplicadoException e) {
                flag = false;
                Console.WriteLine("Atenção: " + e.ToString());
            }
            return flag;
        }


        public static Terreno EliminarTerreno(string nomeFreguesia, int id) {

            Terreno terreno = null;
            try {
                Autarquia autarquia = Dados.CarregarDados();
                Freguesia freguesia = autarquia.GetFreguesiaByNome(nomeFreguesia);
                freguesia.PesquisarTerreno(id);
                terreno = freguesia.EliminarTerreno(id);
                Dados.GuardarDados(autarquia);
            } catch (ElementoNaoExistenteException e) {

                Console.WriteLine("Atenção: " + e.ToString());
            }
            return terreno;


        }
        public static Terreno PesquisarTerreno(string nomeFreguesia, int id)
        {          
            Terreno terreno = null;
            Autarquia autarquia = Dados.CarregarDados();
            Freguesia freguesia = autarquia.GetFreguesiaByNome(nomeFreguesia);
            
            if (freguesia == null)
            {
                throw new NomeFreguesiaInvalidoException("Freguesia não encontrada");
            }
            terreno = freguesia.PesquisarTerreno(id);
            if (terreno == null)
            {
                throw new NomeTerrenoInvalidoException("Este terreno não existe");
            }
            return terreno;
        }

        public static List<Terreno> ObterListaTerrenos(string nomeFreguesia) 
        {           
            Autarquia autarquia = Dados.CarregarDados();
            Freguesia freguesia = autarquia.GetFreguesiaByNome(nomeFreguesia);
            if (freguesia == null)
            {
                throw new NomeFreguesiaInvalidoException("Freguesia não encontrada");
            }
            List<Terreno> lista = freguesia.ObterTodosTerrenos();
            if (lista == null || lista.Count == 0)
            {
                throw new ListaTerrenoVaziaException("Esta freguesia não possui nenhum terreno");
            }
            return lista;

        }
    }
}




