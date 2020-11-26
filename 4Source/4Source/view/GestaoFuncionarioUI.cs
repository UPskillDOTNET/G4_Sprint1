using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.views
{
    class GestaoFuncionarioUI
    {
        public static void MainFuncionario()
        {
            int numInput;
            do
            {
                numInput = MenuFuncionario();
                switch (numInput)
                {
                    case 0:
                        Console.WriteLine("Volta para o menu anterior.");
                        break;
                    case 1:
                        //RegistarFuncionario();
                        Console.WriteLine("ai");
                        break;
                    case 2:
                        //PesquisarFuncionario();
                        Console.WriteLine("a2");
                        break;
                    case 3:
                        //EliminarFuncionario();
                        Console.WriteLine("a3");
                        break;
                    case 4:
                       // AlterarFuncionario();
                        Console.WriteLine("a4");
                        break;
                    case 5:
                        //ListarFuncionarios();
                        Console.WriteLine("a5");
                        break;
                    default:
                        Console.WriteLine("Opção Errada");
                        break;
                }

            } while (numInput != 0);        
        }


        //private static void ListarFuncionarios()
        //{
        //    ArrayList lista = FuncionarioController.ObterListaFuncionarios();
        //    foreach (Funcionario func in lista)
        //    {
        //        Console.WriteLine(func.ToString());
        //    }
        //}

        //private static void AlterarFuncionario()
        //{
        //    int nr = Utils.GetIntNumber("Digite o Numero");
        //    Funcionario func = FuncionarioController.PesquisarFuncionario(nr);
        //    if (func != null)
        //    {
        //        Console.WriteLine(func.ToString());
        //        Funcionario funcAlterada = AlterarFuncionario(func);
        //        FuncionarioController.AlterarFuncionario(funcAlterada);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Não  existe!!!");
        //    }

        //}
        //private static void EliminarFuncionario()
        //{
        //    int nr = Utils.GetIntNumber("Digite o Numero");
        //    Funcionario func = FuncionarioController.EliminarFuncionario(nr);
        //    if (func != null)
        //    {
        //        Console.WriteLine(func.ToString());
        //    }
        //    else
        //    {
        //        Console.WriteLine("Não  existe!!!");
        //    }

        //}

        //private static void PesquisarFuncionario()
        //{
        //    int nr = Utils.GetIntNumber("Digite o Numero");
        //    Funcionario func = FuncionarioController.PesquisarFuncionario(nr);
        //    if (func != null)
        //    {
        //        Console.WriteLine(func.ToString());
        //    }
        //    else
        //    {
        //        Console.WriteLine("Não  existe!!!");
        //    }

        //}
        //private static void RegistarFuncionario()
        //{
        //    Funcionario func = CriarFuncionario();
        //    FuncionarioController.RegistarFuncionario(func);

        //}

        //private static Funcionario CriarFuncionario()
        //{
        //    Funcionario func = new Funcionario();
        //    Pessoa pessoa = PessoaView.CriarPessoa();
        //    func.Nif = pessoa.Nif;
        //    func.Nome = pessoa.Nome;
        //    func.Nascimento = pessoa.Nascimento;
        //    bool flag;
        //    do
        //    {
        //        try
        //        {
        //            flag = false;
        //            func.Numero = Utils.GetIntNumber("Numero");
        //        }
        //        catch (NumeroFuncionarioInvalidoException e)
        //        {
        //            flag = true;
        //            Console.WriteLine("Atenção: " + e.ToString());
        //        }
        //    } while (flag);
        //    func.Cargo = Utils.GetText("Cargo");
        //    return func;
        //}
        //private static Funcionario AlterarFuncionario(Funcionario func)
        //{
        //    //Assumo que não é possível alterar nem o NIF, nem o Numero 
        //    Pessoa pessoa = PessoaView.AlterarPessoa((Pessoa)func);
        //    func.Nif = pessoa.Nif;
        //    func.Nome = pessoa.Nome;
        //    func.Nascimento = pessoa.Nascimento;
        //    func.Cargo = Utils.GetText("Cargo");
        //    return func;
        //}

        private static int MenuFuncionario()
        {
            int numInput = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("\nMenu Funcionario");
                Console.WriteLine("1 - Inserir Funcionario");
                Console.WriteLine("2 - Listar Funcionario");
                Console.WriteLine("3 - Eliminar Funcionario");
                Console.WriteLine("4 - Alterar Funcionario");
                Console.WriteLine("5 - Listar Funcionarios");
                Console.WriteLine("\n0 - Voltar");
            } while (numInput < 0 || numInput > 5);
            return numInput;
        }

    }
}