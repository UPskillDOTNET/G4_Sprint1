using System;
using System.Collections;
using System.Collections.Generic;
using _4Source.controllers;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.views
{
    class GestaoFuncionarioUI
    {
        public static void Menu()
        {
                int numInput;
               

                do
                {   Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n===Gestão de Funcionarios===\n\n");
                    Console.ResetColor();
                    Console.WriteLine("1 - Inserir Funcionario");
                    Console.WriteLine("2 - Listar Funcionario");
                    Console.WriteLine("3 - Eliminar Funcionario");
                    Console.WriteLine("4 - Listar Funcionarios");
                    Console.WriteLine("\n5 - Voltar\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("===========================\n");
                    Console.ResetColor();

                    numInput = Utils.GetIntNumber("Por favor escolha uma opção:");

                    switch (numInput)
                    {
                        case 1:
                            RegistarFuncionario();
                            break;
                        case 2:
                            PesquisarFuncionario();
                            break;
                        case 3:
                            EliminarFuncionario();
                            break;
                        case 4:
                            ListarFuncionarios();
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Volta para o menu anterior");
                            Console.ReadKey();
                            break;
                        default:
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opção errada. Escolha novamente.");
                        Console.ReadKey();
                        break;
                    }
                } while (numInput != 5);
           
        }


        private static void ListarFuncionarios()
        {
            List<Funcionario> lista = RegistoFuncionarioController.ObterListaFuncionarios();
            foreach (Funcionario func in lista)
            {
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine(func.ToString());
            }
       
        }

        private static void EliminarFuncionario()
        {
            string nr = Utils.GetText("Digite o Numero:");
            Funcionario func = RegistoFuncionarioController.EliminarFuncionario(nr);
            if (func != null)
            {
                Console.WriteLine(func.ToString());
            }
            else
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não  existe!!!");
                Console.ResetColor();
            }
        }

        private static void PesquisarFuncionario()
        {
            string nr = Utils.GetText("Digite o Numero:");
            Funcionario func = RegistoFuncionarioController.PesquisarFuncionario(nr);
            if (func != null)
            {
                Console.WriteLine(func.ToString());
            }
            else
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não  existe!!!");
                Console.ResetColor();
            }
        }
        private static void RegistarFuncionario()
        {
            Funcionario func = Pessoa.CriarFuncionario();
            RegistoFuncionarioController.RegistarFuncionario(func);
        }

     
    }

}

