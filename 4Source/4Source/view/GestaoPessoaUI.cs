using _4Source.controllers;
using System;
using System.Collections;

namespace _4Source.views
{
    class GestaoPessoaUI
    {
      
        public static void Menu()
        {
            Console.WriteLine("\n=== Gestão de Pessoas ===");
            Console.WriteLine("1 - Registar Pessoa");
            Console.WriteLine("2 - Pesquisar Pessoa");
            Console.WriteLine("3 - Editar Pessoa");
            Console.WriteLine("4 - Eliminar Pessoa");
            Console.WriteLine("5 - Mostrar lista de Pessoas");
            Console.WriteLine("\n6 - Voltar ao Menu Principal");

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
                        Console.WriteLine("Volta para o menu anterior.");
                        break;
                    default:
                        Console.WriteLine("Opção errada. Escolha novamente.");
                        Menu();
                        break;
                }
            } while (input != 0);
        }

        private static void ListarPessoas()
        {
            ArrayList lista = RegistoPessoaController.ObterListaPessoas();
            foreach (Pessoa pessoa in lista)
            {
                Console.WriteLine(pessoa.ToString());
            }
            Menu();
        }


        private static void AlterarPessoa()
        {
            string nif = GetText("Digite o NIF");
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
            string nif = GetText("Digite o NIF");
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
            string nif = GetText("Digite o NIF");
            Pessoa pessoa = RegistoPessoaController.PesquisarPessoa(nif);
            if (pessoa != null)
            {
                Console.WriteLine(pessoa.ToString());
            }
            else
            {
                Console.WriteLine("Não existe!!!");
            }
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
                    pessoa.Nif = GetText("NIF");
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
                    pessoa.Nome = GetText("Nome");
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
                    pessoa.DataNascimento = new DateTime();
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
                    pessoa.Nome = GetText("Nome");
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

        public static string GetText(string label)
        {
            string text = "";
            Console.WriteLine(label + ": ");
            text = Console.ReadLine();
            return text;
        }
    }
}
