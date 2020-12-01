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
        public static List<Pessoa> MostrarPessoasDeterminadaData(DateTime data)
        {
            Autarquia autarquia = Dados.CarregarDados();
            List<Pessoa> lista = autarquia.MostrarPessoasDeterminadaData(data);
            return lista;
        }

        public static List<Pessoa> MostrarTop5PessoasMaisVelhas()
        {
            Autarquia autarquia = Dados.CarregarDados();
            List<Pessoa> lista = autarquia.MostrarTop5PessoasMaisVelhas();
            return lista;
        }

        public static double MostrarAreaTotalAutarquia()
        {
            double areaTotal = 0;

            Autarquia autarquia = Dados.CarregarDados();
            areaTotal = autarquia.MostrarAreaTotalAutarquia();
            return areaTotal;

        }

        public static double MostrarPercentagemAreaRuralAutarquia()
        {

            double areaRural = 0;

            Autarquia autarquia = Dados.CarregarDados();
            areaRural = autarquia.MostrarPercentagemAreaRuralAutarquia();
            return areaRural;

        }

        public static string MostrarAreaPredominanteFreguesia(string nome)
        {

            Autarquia autarquia = Dados.CarregarDados();
            Freguesia freguesia = autarquia.GetFreguesiaByNome(nome);
            string areaPred = autarquia.MostrarAreaPredominanteFreguesia(freguesia);
            return areaPred;
        }

        public static List<Freguesia> CalcContriAutarquia()
        {
            Autarquia autarquia = Dados.CarregarDados();
            List<Freguesia> lista = autarquia.CalcContriAutarquia();
            return lista;
        }

        public static List<Pessoa> MostrarTopProprietarios()
        {
            Autarquia autarquia = Dados.CarregarDados();
            List<Pessoa> lista = autarquia.MostrarTopProprietarios();
            return lista;
        }

        public static List<Terreno> MostrarListaTerrenosInspecao(DateTime data, string nome)
        {
            Autarquia autarquia = Dados.CarregarDados();
            List<Terreno> lista = autarquia.MostrarListaTerrenosInspecao(data, nome);
            return lista;
        }

        public static List<Freguesia> MostrarFreguesiasDimensao()
        {
            Autarquia autarquia = Dados.CarregarDados();
            List<Freguesia> lista = autarquia.MostrarFreguesiasDimensao();
            return lista;
        }
    }
}
