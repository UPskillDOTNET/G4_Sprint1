using _4Source.controllers;
using System;
using System.Collections;
using _4Source.view;

namespace _4Source.views
{
    class GestaoPessoaUI
    {

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n=== Gestão de Pessoas ===\n\n");
            Console.WriteLine("1 - Registar Pessoa");
            Console.WriteLine("2 - Pesquisar Pessoa");
            Console.WriteLine("3 - Editar Pessoa");
            Console.WriteLine("4 - Eliminar Pessoa");
            Console.WriteLine("5 - Mostrar Lista de Pessoas");
            Console.WriteLine("6 - Voltar ao Menu Principal");
            Console.WriteLine("===========================\n");
            int input = int.Parse(Console.ReadLine());

            do
            {
                switch (input)
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
                        Console.WriteLine("\nVolta para o menu anterior.\n");
                        Console.ReadKey();
                        _4Source.views.Menu.mainMenu();
                        break;
                    default:
                        Console.WriteLine("\nOpção errada. Escolha novamente.\n");
                        Menu();
                        break;
                }
            } while (input != 6);
        }

        private static void ListarPessoas()
        {
            ArrayList lista = RegistoPessoaController.ObterListaPessoas();
            foreach (Pessoa pessoa in lista)
            {
                Console.WriteLine(pessoa.ToString());
            }
            Console.ReadKey();
            Menu();
        }


        private static void AlterarPessoa()
        {
            string nif = Utils.GetText("Digite o NIF");
            Pessoa pessoa = RegistoPessoaController.PesquisarPessoa(nif);
            if (pessoa != null)
            {
                Console.WriteLine(pessoa.ToString());
                Pessoa pessoaAlterada = AlterarPessoa(pessoa);
                RegistoPessoaController.AlterarPessoa(pessoaAlterada);
            }
            else
            {
                Console.WriteLine("Não existe!!!");
            }
            Menu();

        }
        private static void EliminarPessoa()
        {
            string nif = Utils.GetText("Digite o NIF");
            Pessoa pessoa = RegistoPessoaController.EliminarPessoa(nif);
            if (pessoa != null)
            {
                Console.WriteLine(pessoa.ToString());
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }
            Menu();

        }

        private static void PesquisarPessoa()
        {
            string nif = Utils.GetText("Digite o NIF");
            Pessoa pessoa = RegistoPessoaController.PesquisarPessoa(nif);
            if (pessoa != null)
            {
                Console.WriteLine(pessoa.ToString());
            }
            else
            {
                Console.WriteLine("Não existe!!!");
            }
            Console.ReadKey();
            Menu();
        }

        private static void RegistarPessoa()
        {
            Pessoa pessoa = CriarPessoa();
            RegistoPessoaController.RegistarPessoa(pessoa);
            Menu();

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
                    pessoa.Nif = Utils.GetText("NIF");
                }
                catch (NifInvalidoException e)
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
                    pessoa.Nome = Utils.GetText("Nome");
                }
                catch (NomePessoaInvalidoException e)
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
                    pessoa.DataNascimento = Utils.GetDataNascimento();
                }
                catch (NomePessoaInvalidoException e)
                {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
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
                    pessoa.Nome = Utils.GetText("Nome");
                }
                catch (NomePessoaInvalidoException e)
                {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
            pessoa.DataNascimento = new DateTime();
            return pessoa;
        }

        
    }
}
