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
            Console.WriteLine("\n===Gestão de Terrenos===");
            Console.WriteLine("1 - Inserir Terreno");
            Console.WriteLine("2 - Listar Terreno");
            Console.WriteLine("3 - Eliminar Terreno");
            Console.WriteLine("4 - Listar Terrenos");
            Console.WriteLine("5 - Calcular Percentagem de Posse de Terreno");
            Console.WriteLine("\n5 - Voltar\n");
            Console.WriteLine("===========================\n");

            do
            {
                numInput = Utils.GetIntNumber("Por favor escolha uma opção: ");
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
                        CalcularPercentagem();
                        break;
                    case 6:
                        Console.WriteLine("\nVolta para o menu anterior.");
                        Console.ReadKey();
                        views.Menu.mainMenu();
                        break;
                    default:
                        Console.WriteLine("\nOpção Errada");
                        break;
                }

            } while (numInput != 6);

        }
        private static void ListarTerrenos()
        {
            string nome = Utils.GetText("Digite o nome da Freguesia:");
            ArrayList lista = RegistoTerrenoController.ObterListaTerrenos(nome);
            foreach (Terreno terreno in lista)
            {
                Console.WriteLine("\n" + terreno.ToString());
            }
            Console.ReadKey();
            Menu();
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
            Menu();
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
            Menu();
        }
        private static void RegistarTerreno()
        {
            string nome = Utils.GetText("\nIntroduza o nome da freguesia a qual o terreno pertence:");
            Terreno terreno = CriarTerreno();
            RegistoTerrenoController.RegistarTerreno(nome, terreno);
            Menu();
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
                try
                {
                    flag = false;
                    terreno.IndiceCont = Utils.GetDouble("Indice de Contribuição:");
                }
                catch (IndiceTerrenoInvalidoException e)
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

        public static void CalcularPercentagem()
        {
            Console.WriteLine("Quantos proprietários tem o terreno?");
            int numProprietarios = int.Parse(Console.ReadLine());
            double percentagem = 0;
            double totalPercentagem = 0;
            double[] array = new double[numProprietarios];
            int count = 1;

            for (int i = 0; i < numProprietarios; i++)
            {
                Console.WriteLine("Introduza a percentagem do proprietario:");
                percentagem = double.Parse(Console.ReadLine());
                array[i] = percentagem;
                totalPercentagem += percentagem;
            }
            foreach (double perc in array)
            {

                Console.WriteLine("O proprietário {0} possui {1} % do terreno", count, perc);
                count += 1;
            }
            double sum = array.Sum();
            Console.WriteLine("Posse total dos proprietários em relação ao terreno: {0} ", sum);

        }
    }
}
