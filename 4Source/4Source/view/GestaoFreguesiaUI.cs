using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Source.controllers;
using _4Source.view;

namespace _4Source.views
{
    class GestaoFreguesiaUI
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n===Gestão de Freguesias===\n\n");
            Console.WriteLine("1 - Inserir Freguesia");
            Console.WriteLine("2 - Listar Freguesia");
            Console.WriteLine("3 - Eliminar Freguesia");
            Console.WriteLine("4 - Alterar Freguesia");
            Console.WriteLine("5 - Listar Freguesias");
            Console.WriteLine("\n6 - Voltar\n");
            Console.WriteLine("===========================\n");
            int numInput = Int32.Parse(Console.ReadLine());
            do
            {
                switch (numInput)
                {
                  
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
                    case 6:
                        Console.WriteLine("Volta para o menu anterior.\n");
                        Console.ReadKey();
                        _4Source.views.Menu.mainMenu();
                        break;
                    default:
                        Console.WriteLine("Opção Errada\n");
                        Console.ReadKey();
                        Menu();
                        break;
                }

            } while (numInput != 6);

        }
         private static void ListarFreguesias()
        {
            ArrayList lista = RegistoFreguesiaController.ObterListaFreguesias();
            foreach (Freguesia freguesia in lista)
            {
                Console.WriteLine(freguesia.ToString());
            }
            Console.ReadKey();
            Menu();
        }

        private static void AlterarFreguesia()
        {
            string nome = Utils.GetText("Digite o Nome");
            Freguesia freguesia = RegistoFreguesiaController.PesquisarFreguesia(nome);
            if (freguesia != null)
            {
                Console.WriteLine(freguesia.ToString());
                Freguesia freguesiaAlterada = AlterarFreguesia(freguesia);
                RegistoFreguesiaController.AlterarFreguesia(freguesiaAlterada);
            }
            else
            {
                Console.WriteLine("A freguesia que indicou não existe na base de dados. Tente novamente.");
            }
            Console.ReadKey();
            Menu();
        }
        private static void EliminarFreguesia()
        {
            string nome = Utils.GetText("Digite o Nome");
            Freguesia freguesia = RegistoFreguesiaController.EliminarFreguesia(nome);
            if (freguesia != null)
            {
                Console.WriteLine(freguesia.ToString());
            }
            else
            {
                Console.WriteLine("Essa freguesia não existe!");
            }
            Console.ReadKey();
            Menu();

        }

        private static void PesquisarFreguesia()
        {
            string nome = Utils.GetText("Digite o Nome");
            Freguesia freguesia = RegistoFreguesiaController.PesquisarFreguesia(nome);
            if (freguesia != null)
            {
                Console.WriteLine(freguesia.ToString());
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }
            Console.ReadKey();
            Menu();

        }
        private static void RegistarFreguesia()
        {
            Freguesia freguesia = CriarFreguesia();
            RegistoFreguesiaController.RegistarFreguesia(freguesia);
            Menu();
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
                    freguesia.Nome = Utils.GetText("Nome");
                }
                catch (NomeFreguesiaInvalidoException e)
                {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
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
                catch (NomeFreguesiaInvalidoException e)
                {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
            return freguesia;
        }

    }
}

