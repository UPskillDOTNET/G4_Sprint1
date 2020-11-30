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

        public static ArrayList MostrarTop5PessoasMaisVelhas()
        {
            Autarquia autarquia = Dados.CarregarDados();
            ArrayList lista = autarquia.MostrarTop5PessoasMaisVelhas();
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

    //    public static string MostrarAreaPredominanteFreguesia() {
    //        string
    //}
    }
}
