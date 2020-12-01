﻿using System;
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


                do { 
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
                    numInput = Utils.GetIntNumber("Por favor escolha uma opção:");
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
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nOpção Errada");
                            break;
                    }
                } while (numInput != 5);
          

        }
        private static void ListarTerrenos()
        {
            bool flag = false;
            List<Terreno> lista;
            do // while(true)
            {
                string nome = Utils.GetText("Digite o nome da Freguesia:");
                try
                {
                    flag = false;
                    lista = RegistoTerrenoController.ObterListaTerrenos(nome);
                    foreach (Terreno terreno in lista)
                    {
                        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                        Console.WriteLine("\n" + terreno.ToString());
                    }
                    // break;
                }
                catch (NomeFreguesiaInvalidoException ex)
                {
                    flag = true;
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
                catch (ListaTerrenoVaziaException ex)
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }

            } while (flag);
            Console.ReadKey();
        
        }
        private static void PesquisarTerreno()
        {
            string nome = Utils.GetText("\nDigite o Nome da Freguesia:");
            int id = Utils.GetIntNumber("\nDigite o Id:");
            try
            {
                Terreno terreno = RegistoTerrenoController.PesquisarTerreno(nome, id);
                Console.WriteLine(terreno.ToString());

            }
            catch (MasterException ex)
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ResetColor();
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
                Console.WriteLine("------------------------------");
                Console.WriteLine(terreno.ToString());
                Console.WriteLine("------------------------------");
            }
            else
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Não  existe!!!");
                Console.ResetColor();
            }
            Console.ReadKey();
            
        }


        private static void RegistarTerreno()
        {
            string nome = Utils.GetText("\nIntroduza o nome da freguesia a qual o terreno pertence:");
            Terreno terreno = Freguesia.CriarTerreno();
            RegistoTerrenoController.RegistarTerreno(nome, terreno);
           
        } 
       
    }
}
