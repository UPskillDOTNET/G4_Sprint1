﻿using _4Source.controllers;
using System;
using System.Collections;
using System.Collections.Generic;

namespace _4Source.views
{
    class GestaoPessoaUI
    {

        public static void Menu()
        {
          
                int numInput;
               

                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n=== Gestão de Pessoas ===\n\n");
                    Console.ResetColor();
                    Console.WriteLine("1 - Registar Pessoa");
                    Console.WriteLine("2 - Pesquisar Pessoa");
                    Console.WriteLine("3 - Editar Pessoa");
                    Console.WriteLine("4 - Eliminar Pessoa");
                    Console.WriteLine("5 - Mostrar Lista de Pessoas");
                    Console.WriteLine("\n6 - Voltar ao Menu Principal\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("===========================\n");
                    Console.ResetColor();

                    numInput = Utils.GetIntNumber("Por favor escolha uma opção:");
                    switch (numInput)
                    {
                        case 1:
                            RegistarPessoa();
                            break;
                        case 2:
                            PesquisarPessoa();
                            break;
                        case 3:
                            AlterarPessoa();
                            break;
                        case 4:
                            EliminarPessoa();
                            break;
                        case 5:
                            ListarPessoas();
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nVolta para o menu anterior.\n");
                            Console.ReadKey();

                            break;
                        default:
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nOpção errada. Escolha novamente.\n");

                            break;
                    }
                } while (numInput != 6);
           
        }

        private static void ListarPessoas()
        {
            List<Pessoa> lista = RegistoPessoaController.ObterListaPessoas();
            foreach (Pessoa pessoa in lista)
            {
                
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine("------------------------------");
                Console.WriteLine(pessoa.ToString());
                Console.WriteLine("------------------------------");
            }
            Console.ReadKey();
         
        }


        private static void AlterarPessoa()
        {
            string nif = Utils.GetText("Digite o NIF da pessoa que quer alterar: ");
            Pessoa pessoa = RegistoPessoaController.PesquisarPessoa(nif);
            if (pessoa != null)
            {
                Console.WriteLine(pessoa.ToString());
                Pessoa pessoaAlterada = AlterarPessoa(pessoa);
                RegistoPessoaController.AlterarPessoa(pessoaAlterada);
            }
            else
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não existe!!!");
                Console.ResetColor();
            }
           

        }
        private static void EliminarPessoa()
        {
            string nif = Utils.GetText("Digite o NIF da pessoa a ser eliminada: ");
            Pessoa pessoa = RegistoPessoaController.EliminarPessoa(nif);
            if (pessoa != null)
            {
                Console.WriteLine(pessoa.ToString());
            }
            else
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não  existe!!!");
                Console.ResetColor();
            }
           

        }

        private static void PesquisarPessoa()
        {
            string nif = Utils.GetText("Digite o NIF da pessoa que quer pesquisar: ");
            Pessoa pessoa = RegistoPessoaController.PesquisarPessoa(nif);
            if (pessoa != null)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine(pessoa.ToString());
                Console.WriteLine("------------------------------");
            }
            else
            {
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não existe!!!");
                Console.ResetColor();
            }
            Console.ReadKey();
          
        }

        private static void RegistarPessoa()
        {
            Pessoa pessoa = CriarPessoa();
            RegistoPessoaController.RegistarPessoa(pessoa);
    

        }

        public static Pessoa CriarPessoa()
        {
            Pessoa pessoa = new Pessoa();
            bool flag;

            do
            {
                try
                {
                    flag = false;
                    pessoa.Nif = Utils.GetText("NIF:");
                }
                catch (NifInvalidoException e)
                {
                    flag = true;
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Atenção: NIF Invalido.");
                }
            } while (flag);
            do
            {
                try
                {
                    flag = false;
                    pessoa.Nome = Utils.GetText("Nome:");
                }
                catch (NomeInvalidoException e)
                {
                    flag = true;
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Atenção: Nome Invalido.");
                }
            } while (flag);
            do
            {
                try
                {
                    flag = false;
                    pessoa.DataNascimento = Utils.GetDataNascimento();
                }
                catch (DataInvalidaException e)
                {
                    flag = true;
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Atenção: Data Invalida.");
                }
            } while (flag);
            return pessoa;
        }
        public static Pessoa AlterarPessoa(Pessoa pessoa)
        {
            bool flag;
            do
            {
                try
                {
                    flag = false;
                    pessoa.Nome = Utils.GetText("Nome: ");
                }
                catch (NomePessoaInvalidoException e)
                {
                    flag = true;
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Atenção: " + e.ToString());
                    Console.ResetColor();
                }
            } while (flag);
            pessoa.DataNascimento = new DateTime();
            return pessoa;
        }

        
    }
}
