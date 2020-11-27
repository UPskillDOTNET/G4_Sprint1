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
                        CriarPessoa();
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
                    case 0:
                        Console.WriteLine("Volta para o menu anterior.");
                        break;
                    default:
                        Console.WriteLine("Opção errada. Escolha novamente.");
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

        }
        private static void RegistarPessoa()
        {
            Pessoa pessoa = CriarPessoa();
            RegistoPessoaController.RegistarPessoa(pessoa);

        }

        private static Pessoa CriarPessoa()
        {
            Pessoa pessoa = new Pessoa();

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
            func.Cargo = Utils.GetText("Cargo");
            return func;
        }
        private static Pessoa AlterarPessoa(Pessoa pessoa)
        {
            Pessoa pessoa = PessoaView.AlterarPessoa((Freguesia)func);
            func.Nif = pessoa.Nif;
            func.Nome = pessoa.Nome;
            func.Nascimento = pessoa.Nascimento;
            func.Cargo = GetText("Cargo");
            return func;
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
