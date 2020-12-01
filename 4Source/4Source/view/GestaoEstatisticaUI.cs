using _4Source.controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.views
{
    class GestaoEstatisticaUI
    {
        public static void Menu()
        {
           
                int numInput;
          
                do
                {
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
                    Console.WriteLine("7) Apresentar a atividade rural predominante numa dada freguesia.");
                    Console.WriteLine("8) Apresentar uma listagem dos terrenos do tipo industrial com a data de inspeção posterior a uma dada data.");
                    Console.WriteLine("9) Consultar o top 5 das pessoas com mais terrenos.");
                    Console.WriteLine("\n0) Voltar para o menu anterior\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(":===============////===========////==========///===================////===================:\n");
                    Console.ResetColor();
                    numInput = Utils.GetIntNumber("Por favor escolha uma opção:");

                    switch (numInput)
                    {
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
                            CalcContriAutarquia();
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
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nVolta para o menu anterior.");
                            Console.ReadKey();
                            break;
                        default:
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opção Errada");
                            break;
                    }

                } while (numInput != 0);
          

    
        }
        private static void MostrarPessoasDeterminadaData() {
            DateTime data = Utils.GetDataNascimento();
            List<Pessoa> lista = RegistoEstatisticaController.MostrarPessoasDeterminadaData(data);
            foreach (Pessoa p in lista)
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine("\n" + p.ToString());
            }
            Console.ReadKey();

        }
        private static void MostrarTop5PessoasMaisVelhas()
        {
            List<Pessoa> lista = RegistoEstatisticaController.MostrarTop5PessoasMaisVelhas();
            foreach (Pessoa p in lista)
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine("\n" + p.ToString());
            }
            Console.ReadKey();
        }

        private static double MostrarAreaTotalAutarquia() 
        {
            double areaTotal = RegistoEstatisticaController.MostrarAreaTotalAutarquia();
            Console.WriteLine("A área total da autarquia é de: {0}", areaTotal);
            return areaTotal;
        }

        private static void MostrarPercentagemAreaRuralAutarquia() {

            double areaTotal = MostrarAreaTotalAutarquia();
            double areaRural = RegistoEstatisticaController.MostrarPercentagemAreaRuralAutarquia();
            double percentagemRural = (areaRural / areaTotal) * 100;
            Console.WriteLine("A percentagem da área rural da autarquia é de {0} %", percentagemRural);
      
        }

        private static void CalcContriAutarquia()
        {

            List<Freguesia> lista = RegistoEstatisticaController.CalcContriAutarquia();
            foreach (Freguesia f in lista)
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine("\n" + f.ToString());
            }
            Console.ReadKey();


        }
        private static void MostrarFreguesiasDimensao() {
            List<Freguesia> lista = RegistoEstatisticaController.MostrarFreguesiasDimensao();
                foreach (Freguesia f in lista)
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine("\n" + f.ToString());
            }
        }

        private static void MostrarAreaPredominanteFreguesia()
        {
            string nome = Utils.GetText("Digite o Nome da Freguesia");
            string result = RegistoEstatisticaController.MostrarAreaPredominanteFreguesia(nome);
            Console.WriteLine("A área predominante é: {0}", result);
        }

        private static void MostrarListaTerrenosInspecao() {
            string nome = Utils.GetText("Digite o Nome da Freguesia");
            DateTime data = Utils.GetData();
         
            List<Terreno> lista = RegistoEstatisticaController.MostrarListaTerrenosInspecao(data, nome);
            foreach (Terreno t in lista)
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine("\n" + t.ToString());
            }
            Console.ReadKey();
        }
        private static void MostrarTop5PessoasMaisTerrenos()
        {

            List<Pessoa> lista = RegistoEstatisticaController.MostrarTopProprietarios();
            foreach (Pessoa p in lista)
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine("\n" + p.ToString());
            }
            Console.ReadKey();

        }
    }
}

