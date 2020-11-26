using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.views
{
    class GestaoFreguesiaUI
    {
        public static void MainFreguesia()
        {

            Console.WriteLine("\nMenu Funcionario");
            Console.WriteLine("1 - Inserir Funcionario");
            Console.WriteLine("2 - Listar Funcionario");
            Console.WriteLine("3 - Eliminar Funcionario");
            Console.WriteLine("4 - Alterar Funcionario");
            Console.WriteLine("5 - Listar Funcionarios");
            Console.WriteLine("\n0 - Voltar");
            int numInput = Int32.Parse(Console.ReadLine());
            do
            {
                switch (numInput)
                {
                    case 0:
                        Console.WriteLine("Volta para o menu anterior.");
                        break;
                    case 1:
                        RegistarFreguesia();
                        break;
                    case 2:
                        PesquisarFreguesia();
                        break;
                    case 3:
                        EliminarFreguesia();
                        break;
                    case 4:
                        AlterarFreguesia();
                        break;
                    case 5:
                        ListarFreguesias();
                        break;
                    default:
                        Console.WriteLine("Opção Errada");
                        break;
                }

            } while (numInput != 0);

        }
         private static void ListarFreguesias()
        {
            ArrayList lista = FregesiaController.ObterListaFreguesias();
            foreach (Freguesia freguesia in lista)
            {
                Console.WriteLine(freguesia.ToString());
            }
        }

        private static void AlterarFreguesia()
        {
            long nif = Utils.GetLongNumber("Digite o NIF");
            Freguesia freguesia = FreguesiaController.PesquisarFreguesia(nome);
            if (freguesia != null)
            {
                Console.WriteLine(freguesia.ToString());
                Freguesia freguesiaAlterada = AlterarFreguesia(freguesia);
                PessoaController.AlterarFreguesia(freguesiaAlterada);
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }

        }
        private static void EliminarFreguesia()
        {
            long nif = Utils.GetLongNumber("Digite o NIF");
            Freguesia freguesia = FreguesiaController.EliminarFreguesia(nome);
            if (freguesia != null)
            {
                Console.WriteLine(freguesia.ToString());
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }

        }

        private static void PesquisarFreguesia()
        {
            long nif = Utils.GetLongNumber("Digite o NIF");
            Freguesia freguesia = FreguesiaController.PesquisarFreguesia(nome);
            if (freguesia != null)
            {
                Console.WriteLine(freguesia.ToString());
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }

        }
        private static void RegistarFreguesia()
        {
            Freguesia freguesia = CriarFreguesia();
            FreguesiaController.Registarfreguesia(freguesia);

        }

        public static Freguesia CriarFreguesia()
        {
            Freguesia freguesia = new Freguesia();
            bool flag;
            do
            {
                try
                {
                    flag = false;
                    freguesia.Nif = Utils.GetLongNumber("NIF");
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
                    freguesia.Nome = Utils.GetText("Nome");
                }
                catch (NomePessoaInvalidoException e)
                {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
            freguesia.Nascimento = DataView.GetData();
            return freguesia;
        }
        public static Freguesia AlterarFreguesia(Freguesia freguesia)
        {
            bool flag;
           
            do
            {
                try
                {
                    flag = false;
                    freguesia.Nome = Utils.GetText("Nome");
                }
                catch (NomePessoaInvalidoException e)
                {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
            freguesia.Nascimento = DataView.GetData();
            return freguesia;
        }
    }
}

