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
        public static Terreno PesquisarTerreno(string nomeFreguesia, int id) {

            Terreno terreno = null;
            Autarquia autarquia = Dados.CarregarDados();
            Freguesia freguesia = autarquia.GetFreguesiaByNome(nomeFreguesia);
            terreno = freguesia.PesquisarTerreno(id);
            return terreno;

        }

        public static ArrayList ObterListaTerrenos(string nomeFreguesia) {

            ArrayList lista = null;

            Autarquia autarquia = Dados.CarregarDados();
            Freguesia freguesia = autarquia.GetFreguesiaByNome(nomeFreguesia);
            lista = freguesia.ObterTodosTerrenos();
            return lista;

        }
    }
}




