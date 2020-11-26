using System;
using System.Collections;
using _4Source;

namespace _4Source.controllers
{
    class RegistoTerrenoController
    {
        public static bool RegistarTerreno(Terreno terreno) {
            bool flag = true;
            try {
                Autarquia autarquia = Dados.CarregarDados();
                autarquia.RegistarTerreno(terreno);
                Dados.GuardarDados(autarquia);
            } catch (TerrenoDuplicadoException e) {
                flag = false;
                Console.WriteLine("Atenção: " + e.ToString());
            }
            return flag;
        }

        public static bool AlterarTerreno(Terreno terreno) {
            bool flag = true;
            try {
                Autarquia autarquia = Dados.CarregarDados();
                autarquia.AlterarTerreno(terreno);
                Dados.GuardarDados(autarquia);
            } catch (ElementoNaoExistenteException e) {
                flag = false;
                Console.WriteLine("Atenção: " + e.ToString());
            }
            return flag;
        }

        public static Terreno EliminarTerreno(int id) {

            Terreno terreno = null;
            try {
                Autarquia autarquia = Dados.CarregarDados();
                terreno = autarquia.EliminarTerreno(id);
                Dados.GuardarDados(autarquia);
            } catch (ElementoNaoExistenteException e) {

                Console.WriteLine("Atenção: " + e.ToString());
            }
            return terreno;


        }
        public static Terreno PesquisarTerreno(int id) {

            Terreno terreno = null;
            Autarquia autarquia = Dados.CarregarDados();
            terreno = autarquia.PesquisarTerreno(id);
            //Dados.GuardarDados(autarquia);
            return terreno;

        }

        public static ArrayList ObterListaTerrenos() {

            ArrayList lista = null;

            Autarquia autarquia = Dados.CarregarDados();
            lista = autarquia.ObterTodosTerrenos();
            //Dados.GuardarDados(autarquia);
            return lista;

        }
    }
}




