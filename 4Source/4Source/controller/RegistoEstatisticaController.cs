using _4Source.persistencia;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.controller
{
    class RegistoEstatisticaController
    {
        public static ArrayList MostrarPessoasDeterminadaData(DateTime data)
        {
            Autarquia autarquia = Dados.CarregarDados();
            ArrayList lista = autarquia.MostrarPessoasDeterminadaData(data);
            return lista;
        }

        public static bool AlterarFreguesia(Freguesia freguesia, string nomeNovo)
        {
            bool flag = true;
            try
            {
                Autarquia autarquia = Dados.CarregarDados();
                autarquia.AlterarFreguesia(freguesia, nomeNovo);
            }
            catch (ElementoNaoExistenteException e)
            {
                flag = false;
                Console.WriteLine("Atenção: " + e.ToString());
            }
            return flag;
        }

        public static Freguesia PesquisarFreguesia(string nome)
        {

            Freguesia freguesia = null;
            Autarquia autarquia = Dados.CarregarDados();
            freguesia = autarquia.PesquisarFreguesia(nome);
            return freguesia;

        }

        public static ArrayList ObterListaFreguesias()
        {

            ArrayList lista = null;

            Autarquia autarquia = Dados.CarregarDados();
            lista = autarquia.ObterTodasFreguesias();
            return lista;

        }

        public static Freguesia EliminarFreguesia(string nome)
        {

            Freguesia freguesia = null;
            try
            {
                Autarquia autarquia = Dados.CarregarDados();
                freguesia = autarquia.EliminarFreguesia(nome);
            }
            catch (ElementoNaoExistenteException e)
            {

                Console.WriteLine("Atenção: " + e.ToString());
            }
            return freguesia;
        }
    }
}
