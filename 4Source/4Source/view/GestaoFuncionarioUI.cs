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
            int numInput;
            Console.Clear();
            Console.WriteLine("\n===Gestão de Funcionarios===\n\n");
            Console.WriteLine("1 - Inserir Funcionario");
            Console.WriteLine("2 - Listar Funcionario");
            Console.WriteLine("3 - Eliminar Funcionario");
            Console.WriteLine("4 - Listar Funcionarios");
            Console.WriteLine("\n5 - Voltar\n");
            Console.WriteLine("===========================\n");
            numInput = Utils.GetIntNumber("Por favor escolha uma opção: ");
            do
            {
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
                        Console.WriteLine("Volta para o menu anterior");
                        Console.ReadKey();
                       views.Menu.mainMenu();
                        break;
                    default:
                        Console.WriteLine("Opção errada. Escolha novamente.");
                        Menu();
                        break;
                }

            } while (numInput != 5);
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
            string nr = Utils.GetText("Digite o Numero:");
            Funcionario func = RegistoFuncionarioController.EliminarFuncionario(nr);
            if (func != null)
            {
                Console.WriteLine(func.ToString());
            }
            else
            {
                Console.WriteLine("Não existe!!!");
            }
            Menu();
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
                Console.WriteLine("Não existe!!!");
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
                    func.numeroFunc = Utils.GetText("Numero:");
                }
                catch (NumeroFuncionarioInvalidoException e)
                {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
            func.Cargo = Utils.GetText("Cargo:");
            return func;
        }

          
       

        }

    }

