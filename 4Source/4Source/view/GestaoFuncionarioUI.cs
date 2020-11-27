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
        public static void MainFuncionario()
        {

            Console.WriteLine("\nMenu Funcionario");
            Console.WriteLine("1 - Inserir Funcionario");
            Console.WriteLine("2 - Listar Funcionario");
            Console.WriteLine("3 - Eliminar Funcionario");
            Console.WriteLine("4 - Alterar Funcionario");
            Console.WriteLine("5 - Listar Funcionarios");
            Console.WriteLine("\n6 - Voltar\n");
            int numInput = Int32.Parse(Console.ReadLine());
            do
            {
                switch (numInput)
                {
                    case 6:
                        Console.WriteLine("\nVolta para o menu anterior.\n");
                        break;
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
                        AlterarFuncionario();
                        break;
                    case 5:
                        ListarFuncionarios();
                        break;
                    default:
                        Console.WriteLine("\nOpção Errada\n");
                        break;
                }

            } while (numInput != 6);
        }


        private static void ListarFuncionarios()
        {
            ArrayList lista = RegistoFuncionarioController.ObterListaFuncionarios();
            foreach (Funcionario func in lista)
            {
                Console.WriteLine(func.ToString());
            }
        }

        private static void AlterarFuncionario()
        {
            string nr = GetText("Digite o Numero");
            Funcionario func = RegistoFuncionarioController.PesquisarFuncionario(nr);
            if (func != null)
            {
                Console.WriteLine(func.ToString());
                Funcionario funcAlterada = AlterarFuncionario(func);
                RegistoFuncionarioController.AlterarFuncionario(funcAlterada);
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }

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

        }
        private static void RegistarFuncionario()
        {
            Funcionario func = CriarFuncionario();
            RegistoFuncionarioController.RegistarFuncionario(func);

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
        private static Funcionario AlterarFuncionario(Funcionario func)
        {
            //Assumo que não é possível alterar nem o NIF, nem o Numero 
            Pessoa pessoa = GestaoPessoaUI.AlterarPessoa((Pessoa)func);
            func.Nif = pessoa.Nif;
            func.Nome = pessoa.Nome;
            func.dataNascimento = pessoa.dataNascimento;
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

