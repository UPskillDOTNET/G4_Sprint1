using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Source.controllers;
using _4Source.views;
using System.Collections.Generic;



namespace _4Source.views
{
    class GestaoTerrenoUI
    {
        public static void Menu()
        {
            int numInput;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n===Gestão de Terrenos===");
            Console.ResetColor();
            Console.WriteLine("1 - Inserir Terreno");
            Console.WriteLine("2 - Listar Terreno");
            Console.WriteLine("3 - Eliminar Terreno");
            Console.WriteLine("4 - Listar Terrenos");
            Console.WriteLine("\n5 - Voltar\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===========================\n");
            Console.ResetColor();

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                numInput = Utils.GetIntNumber("Por favor escolha uma opção:");
                Console.ResetColor();
                switch (numInput)
                {
                    case 1:
                        RegistarTerreno();
                        break;
                    case 2:
                        PesquisarTerreno();
                        break;
                    case 3:
                        EliminarTerreno();
                        break;
                    case 4:
                        ListarTerrenos();
                        break;
                 
                    case 5:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("\nVolta para o menu anterior.");
                        Console.ReadKey();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção Errada");
                        break;
                }
            } while (numInput != 5);

        }
        private static void ListarTerrenos()
        {
            string nome = Utils.GetText("Digite o nome da Freguesia:");
            List<Terreno> lista = RegistoTerrenoController.ObterListaTerrenos(nome);
            foreach (Terreno terreno in lista)
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine("\n" + terreno.ToString());
            }
            Console.ReadKey();
        
        }

        private static void EliminarTerreno()
        {
            string nome = Utils.GetText("\n Digite o nome da Freguesia:");
            int id = Utils.GetIntNumber("\n Digite o ID:");
            Terreno terreno = RegistoTerrenoController.EliminarTerreno(nome, id);
            if (terreno != null)
            {
                Console.WriteLine(terreno.ToString());
            }
            else
            {
                Console.WriteLine("\n Não  existe!!!");
            }
            Console.ReadKey();
            
        }

        private static void PesquisarTerreno()
        {
            string nome = Utils.GetText("\nDigite o Nome da Freguesia:");
            int id = Utils.GetIntNumber("\nDigite o Id:");
            Terreno terreno = RegistoTerrenoController.PesquisarTerreno(nome, id);
            if (terreno != null)
            {
                Console.WriteLine(terreno.ToString());
            }
            else
            {
                Console.WriteLine("\nNão  existe!!!");
            }
            Console.ReadKey();
          
        }
        private static void RegistarTerreno()
        {
            string nome = Utils.GetText("\nIntroduza o nome da freguesia a qual o terreno pertence:");
            Terreno terreno = CriarTerreno();
            RegistoTerrenoController.RegistarTerreno(nome, terreno);
           
        }

        public static Terreno CriarTerreno()
        {
            Terreno terreno = new Terreno();
            bool flag;
            do
            {
                try
                {
                    flag = false;
                    terreno.Id = Utils.GetIntNumber("ID");
                }
                catch (IdTerrenoInvalidoException e)
                {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);

            do
            {
                flag = false;
                int number = Utils.GetIntNumber("Que forma tem o terreno?\n1 - Triangular\n2 - Rectangular\n3 - Circular\n");
                switch (number)
                {
                    case 1:

                        terreno.Forma = GetAreaTri();
                        break;
                    case 2:
                        terreno.Forma = GetAreaRect();
                        break;
                    case 3:
                        terreno.Forma = GetAreaCirc();
                        break;
                    default:
                        Console.WriteLine("Erro. Opção inválida");
                        flag = true;
                        break;
                }
            } while (flag);

             do
            {
                flag = false;
                int number = Utils.GetIntNumber("Que Classificação possui o terreno?\n1 - Rural\n2 - Urbana\n3 - Industrial\n");
                switch (number)
                {
                    case 1:

                        terreno.Classificacao = GetRural();
                        break;
                    case 2:
                        terreno.Classificacao = GetUrbana(terreno.Forma.CalcArea());
                        break;
                    case 3:
                        terreno.Classificacao = GetIndustrial(terreno.Forma.CalcArea());
                        break;
                    default:
                        Console.WriteLine("Erro. Opção inválida");
                        flag = true;
                        break;
                }
            } while (flag);

            return terreno;
        }


        private static Triangular GetAreaTri()
        {
            double largura, comprimento;
            do
            {
                largura = Utils.GetDouble("Qual a largura do Terreno?");
                comprimento = Utils.GetDouble("Qual o comprimento do Terreno?");
            } while (largura <= 0 || comprimento <= 0);
            return new Triangular(largura, comprimento);
        }
        private static Rectangular GetAreaRect()
        {
            double largura, comprimento;
            do
            {
                largura = Utils.GetDouble("Qual a largura do Terreno?");
                comprimento = Utils.GetDouble("Qual o comprimento do Terreno?");
            } while (largura <= 0 || comprimento <= 0);
            return new Rectangular(largura, comprimento);
        }
        private static Circular GetAreaCirc()
        {
            double diametro;
            do
            {
                diametro = Utils.GetDouble("Qual o valor do diametro do Terreno?");

            } while (diametro <= 0);
            return new Circular(diametro / 2);
        }

        private static Rural GetRural()
        {
            double indiceCont;
            string descUso;
            do
            {
                indiceCont = Utils.GetDouble("Qual o indice de contribuição do Terreno? (Entre 0 e 1):\n");
            } while (indiceCont < 0 || indiceCont > 1);
            do
            {
                descUso = Utils.GetText("Qual a atividade rural do Terreno? ");

            } while (false);

            return new Rural(indiceCont,descUso);
        }
        private static Urbana GetUrbana(double area)
        {
            double indiceCont;
            string tipologia;
            double areaConst;
            DateTime dataConst;

            do
            {
                indiceCont = Utils.GetDouble("Qual o indice de contribuição do Terreno? (Entre 0 e 1)");
            } while (indiceCont < 0 || indiceCont > 1);
            do
            {
                areaConst = Utils.GetDouble("Qual a area da construção? ");
            } while (areaConst > area || areaConst < 0);
            do
            { 
                tipologia = Utils.GetText("Qual a tipologia da construção? ");
                dataConst = Utils.GetData();
                
            } while (false);
            return new Urbana(indiceCont,tipologia,areaConst,dataConst, area);
        }

        private static Industrial GetIndustrial(double area)
        {
            double indiceCont;
            string desc;
            string tipologia;
            double areaConst;
            DateTime dataConst; 
            DateTime dataInsp;
            string descInsp;
            do
            {
                indiceCont = Utils.GetDouble("Qual o indice de contribuição do Terreno? (Entre 0 e 1)");
            } while (indiceCont < 0 || indiceCont > 1);
            do
            {
                areaConst = Utils.GetDouble("Qual a area da construção? ");
            } while (areaConst > area || areaConst < 0);
            do
            {
                desc = Utils.GetText("Qual a principal atividade industrial do terreno? ");
                tipologia = Utils.GetText("Qual a tipologia da construção? ");
                Console.WriteLine("Qual a data de Construção? ");
                dataConst = Utils.GetData();
                Console.WriteLine("Qual a data da ultima Inspeção? ");
                dataInsp = Utils.GetData();
                descInsp = Utils.GetText("Descrição do relatório da Inspeção: ");
                

            } while (false);
            return new Industrial(indiceCont,desc,tipologia,areaConst,dataConst,dataInsp,descInsp, area);
        }
       
    }
}
