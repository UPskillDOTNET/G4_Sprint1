using _4Source.controllers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    case 6:
                        //VoltarMenuPrincipal();
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
            int nr = Utils.GetIntNumber("Digite o Numero");
            Pessoa pessoa = RegistoPessoaController.PesquisarPessoa(nr);
            if (pessoa != null)
            {
                Console.WriteLine(pessoa.ToString());
                Pessoa pessoa = AlterarPessoa(pessoa);
                RegistoPessoaController.AlterarPessoa(pessoaAlterada);
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }

        }
        private static void EliminarPessoa()
        {
            int nr = Utils.GetIntNumber("Digite o Numero");
            Pessoa pessoa = RegistoPessoaController.EliminarPessoa(nr);
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
            int nr = Utils.GetIntNumber("Digite o Numero");
            Pessoa pessoa = RegistoPessoaController.PesquisarPessoa(nr);
            if (pessoa != null)
            {
                Console.WriteLine(pessoa.ToString());
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }

        }
        private static void RegistarPessoa()
        {
            Pessoa pessoa = CriarPessoa();
            RegistoPessoaController.RegistarPessoa(pessoa);

        }

        private static Funcionario CriarPessoa()
        {
            Pessoa pessoa = new Pessoa();
            Freguesia pessoa = PessoaView.CriarPessoa();
            func.Nif = pessoa.Nif;
            func.Nome = pessoa.Nome;
            func.Nascimento = pessoa.Nascimento;
            bool flag;
            do
            {
                try
                {
                    flag = false;
                    func.Numero = Utils.GetIntNumber("Numero");
                }
                catch (NumeroFuncionarioInvalidoException e)
                {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
            func.Cargo = Utils.GetText("Cargo");
            return func;
        }
        private static Funcionario AlterarFuncionario(Funcionario func)
        {
            //Assumo que não é possível alterar nem o NIF, nem o Numero 
            Freguesia pessoa = PessoaView.AlterarPessoa((Freguesia)func);
            func.Nif = pessoa.Nif;
            func.Nome = pessoa.Nome;
            func.Nascimento = pessoa.Nascimento;
            func.Cargo = Utils.GetText("Cargo");
            return func;
        }
        //public static Pessoa CriarPessoa() { }
        //public static PesquisarPessoa() { }
        //public static EditarPessoa() { }
        //public static EliminarPessoa() { }
        //public static MostrarListaPessoa() { }
        //public static VoltarMenuPrincipal() { }
    }
}
