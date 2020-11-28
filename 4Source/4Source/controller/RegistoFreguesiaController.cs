﻿using System;
using System.Collections;
using _4Source.persistencia;


namespace _4Source.controllers {
    class RegistoFreguesiaController {
        public static bool RegistarFreguesia(Freguesia freguesia) {
            bool flag = true;
            try {
                Autarquia autarquia = Dados.CarregarDados();
                autarquia.RegistarFreguesia(freguesia);
                Dados.GuardarDados(autarquia);
            } catch (FreguesiaDuplicadoException e) {
                flag = false;
                Console.WriteLine("Atenção: " + e.ToString());
            }
            return flag;
        }

        public static bool AlterarFreguesia(Freguesia freguesia, string nomeNovo) {
            bool flag = true;
            try {
                Autarquia autarquia = Dados.CarregarDados();
                autarquia.AlterarFreguesia(freguesia, nomeNovo);
                Dados.GuardarDados(autarquia);
            } catch (ElementoNaoExistenteException e) {
                flag = false;
                Console.WriteLine("Atenção: " + e.ToString());
            }
            return flag;
        }

        public static Freguesia PesquisarFreguesia(string nome) {

            Freguesia freguesia = null;
            Autarquia autarquia = Dados.CarregarDados();
            freguesia = autarquia.PesquisarFreguesia(nome);
            //Dados.GuardarDados(autarquia);
            return freguesia;

        }

        public static ArrayList ObterListaFreguesias() {

            ArrayList lista = null;

            Autarquia autarquia = Dados.CarregarDados();
            lista = autarquia.ObterTodasFreguesias();
            //Dados.GuardarDados(autarquia);
            return lista;

        }

        public static Freguesia EliminarFreguesia(string nome) {

            Freguesia freguesia = null;
            try {
                Autarquia autarquia = Dados.CarregarDados();
                freguesia = autarquia.EliminarFreguesia(nome);
                Dados.GuardarDados(autarquia);
            } catch (ElementoNaoExistenteException e) {

                Console.WriteLine("Atenção: " + e.ToString());
            }
            return freguesia;
        }
    }
}

