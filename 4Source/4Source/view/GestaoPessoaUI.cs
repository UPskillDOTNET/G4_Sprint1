using _4Source.controllers;
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
                            Console.ReadKey();
                        break;
                    }
                } while (numInput != 6);
           
        }

        private static void ListarPessoas()
        {
            List<Pessoa> lista = RegistoPessoaController.ObterListaPessoas();

            if (lista.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNão se encontram pessoas inscritas na plataforma actualmente.");
                Console.ResetColor();
            }

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
                Pessoa pessoaAlterada = RegistoPessoaController.AlterarPessoa(pessoa);
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
        private static void EliminarPessoa()
        {
            string nif = Utils.GetText("Digite o NIF da pessoa a ser eliminada: ");
            Pessoa pessoa = RegistoPessoaController.EliminarPessoa(nif);
            if (pessoa != null)
            {
                Console.WriteLine(pessoa.ToString());
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nA pessoa {0} foi eliminada do sistema.", pessoa.Nome);
                Console.ResetColor();
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
            Pessoa pessoa = Autarquia.CriarPessoa();
            RegistoPessoaController.RegistarPessoa(pessoa);


        }
    }
}
