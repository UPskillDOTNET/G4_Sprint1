﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.views
{
    class GestaoEstatisticaUI
    {
        public static void MainEstatistica()
        {

            int numInput;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n===Mostrar Estatisticas===");
            Console.ResetColor();
            Console.WriteLine("1) Apresentar lista de pessoas que nasceram antes duma determinada data.");
            Console.WriteLine("2) Apresentar lista das 5 pessoas mais velhas.");
            Console.WriteLine("3) Apresentar a área total de terrenos do concelho.");
            Console.WriteLine("4) Apresentar a percentagem de área rural (terrenos rurais) do concelho.");
            Console.WriteLine("5) Apresentar uma listagem das freguesias ordenadas por valor patrimonial dos terrenos do tipo urbano.");
            Console.WriteLine("6) Apresentar uma listagem das freguesias ordenadas por dimensão.");
            Console.WriteLine("7)  Apresentar a atividade rural predominante numa dada freguesia.");
            Console.WriteLine("8)  Apresentar uma listagem dos terrenos do tipo industrial com a data de inspeção posterior a uma dada data.");
            Console.WriteLine("9)  Consultar o top 5 das pessoas com mais terrenos.");
            Console.WriteLine("\n10) Fechar Programa\n\n");
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                numInput = Utils.GetIntNumber("Por favor escolha uma opção:");
                Console.ResetColor();
                switch (numInput)
                {
                    case 0:
                        Console.WriteLine("Volta para o menu anterior.");
                        break;
                    case 1:
                        MostrarPessoasDeterminadaData();
                        break;
                    case 2:
                        MostrarTop5PessoasMaisVelhas();
                        break;
                    case 3:
                        MostrarAreaTotalAutarquia();
                        break;
                    case 4:
                        MostrarPercentagemAreaRuralAutarquia();
                        break;
                    case 5:
                        MostrarListaFreguesiasValorPatrimonial();
                        break;
                    case 6:
                        MostrarFreguesiasDimensao();
                        break;
                    case 7:
                        MostrarAreaPredominanteFreguesia();
                        break;
                    case 8:
                        MostrarListaTerrenosInspecao();
                        break;
                    case 9:
                        MostrarTop5PessoasMaisTerrenos();
                        break;
                    case 10:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nVolta para o menu anterior.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção Errada");
                        break;
                }

            } while (numInput != 10);
        }
        private static void MostrarPessoasDeterminadaData() { }
        private static void MostrarTop5PessoasMaisVelhas() { }
        private static void MostrarAreaTotalAutarquia() { }
        private static void MostrarPercentagemAreaRuralAutarquia() { }
        private static void MostrarListaFreguesiasValorPatrimonial() { }
        private static void MostrarFreguesiasDimensao() { }
        private static void MostrarAreaPredominanteFreguesia() { }
        private static void MostrarListaTerrenosInspecao() { }
        private static void MostrarTop5PessoasMaisTerrenos() { }
    }
}

