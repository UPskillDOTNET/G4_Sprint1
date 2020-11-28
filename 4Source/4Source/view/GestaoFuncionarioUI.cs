using System;
using System.Collections;
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

            Console.WriteLine("\n===Gestão de Funcionarios===\n\n");
            Console.WriteLine("1 - Inserir Funcionario");
            Console.WriteLine("2 - Listar Funcionario");
            Console.WriteLine("3 - Eliminar Funcionario");
            Console.WriteLine("4 - Listar Funcionarios");
            Console.WriteLine("\n5 - Voltar\n");
            Console.WriteLine("===========================\n");
            int input = int.Parse(Console.ReadLine());
            do
            {
                switch (input)
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
                        Console.WriteLine("Volta para o menu anterior");
                        Console.ReadKey();
                        _4Source.views.Menu.mainMenu();
                        break;
                    default:
                        Console.WriteLine("Opção errada. Escolha novamente.");
                        Menu();
                        break;
                }

            } while (input != 5);
        }


        private static void ListarFuncionarios()
        {
            ArrayList lista = RegistoFuncionarioController.ObterListaFuncionarios();
            foreach (Funcionario func in lista)
            {
                Console.WriteLine(func.ToString());
            }
            Menu();
        }

        private static void EliminarFuncionario()
        {
            string nr = GetText("Digite o Numero");
            Funcionario func = RegistoFuncionarioController.EliminarFuncionario(nr);
            if (func != null)
            {
                Console.WriteLine(func.ToString());
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }
            Menu();
        }

        private static void PesquisarFuncionario()
        {
            string nr = GetText("Digite o Numero");
            Funcionario func = RegistoFuncionarioController.PesquisarFuncionario(nr);
            if (func != null)
            {
                Console.WriteLine(func.ToString());
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }
            Menu();

        }
        private static void RegistarFuncionario()
        {
            Funcionario func = CriarFuncionario();
            RegistoFuncionarioController.RegistarFuncionario(func);
            Menu();
        }

        private static Funcionario CriarFuncionario()
        {
            Funcionario func = new Funcionario();
            Pessoa pessoa = GestaoPessoaUI.CriarPessoa();
            func.Nif = pessoa.Nif;
            func.Nome = pessoa.Nome;
            func.dataNascimento = pessoa.dataNascimento;
            bool flag;
            do
            {
                try
                {
                    flag = false;
                    func.numeroFunc = GetText("Numero");
                }
                catch (NumeroFuncionarioInvalidoException e)
                {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
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

