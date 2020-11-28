using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Source.controllers;
using _4Source.view;
using System.Collections.Generic;



namespace _4Source.views
{
    class GestaoTerrenoUI
    {
        public static void Menu()
        {

            Console.Clear();
            Console.WriteLine("\n===Gestão de Terrenos===");
            Console.WriteLine("1 - Inserir Terreno");
            Console.WriteLine("2 - Listar Terreno");
            Console.WriteLine("3 - Eliminar Terreno");
            Console.WriteLine("4 - Listar Terrenos");
            Console.WriteLine("\n5 - Voltar\n");
            Console.WriteLine("===========================\n");
            int numInput = Int32.Parse(Console.ReadLine());
            do
            {
                switch (numInput)
                {
                    case 5:
                        Console.WriteLine("\nVolta para o menu anterior.");
                        Console.ReadKey();
                        break;
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
                    default:
                        Console.WriteLine("\nOpção Errada");
                        break;
                }

            } while (numInput != 5);

        }
        private static void ListarTerrenos()
        {
            string nome = Utils.GetText("Digite o nome da Freguesia");
            ArrayList lista = RegistoTerrenoController.ObterListaTerrenos(nome);
            foreach (Terreno terreno in lista)
            {
                Console.WriteLine(terreno.ToString());
            }
            Console.ReadKey();
            Menu();
        }

        private static void EliminarTerreno()
        {
            string nome = Utils.GetText("Digite o nome da Freguesia");
            int id = Utils.GetIntNumber("Digite o ID");
            Terreno terreno = RegistoTerrenoController.EliminarTerreno(nome, id);
            if (terreno != null)
            {
                Console.WriteLine(terreno.ToString());
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }
            Console.ReadKey();
            Menu();
        }

        private static void PesquisarTerreno()
        {
            string nome = Utils.GetText("Digite o Nome da Freguesia");
            int id = Utils.GetIntNumber("Digite o Id");
            Terreno terreno = RegistoTerrenoController.PesquisarTerreno(nome, id);
            if (terreno != null)
            {
                Console.WriteLine(terreno.ToString());
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }
            Console.ReadKey();
            Menu();
        }
        private static void RegistarTerreno()
        {
            string nome = Utils.GetText("Introduza o nome da freguesia a qual o terreno pertence: ");
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
            return terreno;
        }
        
    }
}
