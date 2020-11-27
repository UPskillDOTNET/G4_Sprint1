using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Source.controllers;

namespace _4Source.views
{
    class GestaoFreguesiaUI
    {
        public static void Menu()
        {

            Console.WriteLine("\nMenu Freguesia");
            Console.WriteLine("1 - Inserir Freguesia");
            Console.WriteLine("2 - Listar Freguesia");
            Console.WriteLine("3 - Eliminar Freguesia");
            Console.WriteLine("4 - Alterar Freguesia");
            Console.WriteLine("5 - Listar Freguesias");
            Console.WriteLine("\n0 - Voltar\n");
            int input = int.Parse(Console.ReadLine());
            do
            {
                switch (input)
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

            } while (input != 0);

        }
         private static void ListarFreguesias()
        {
            ArrayList lista = RegistoFreguesiaController.ObterListaFreguesias();
            foreach (Freguesia freguesia in lista)
            {
                Console.WriteLine(freguesia.ToString());
            }
            Menu();
        }

        private static void AlterarFreguesia()
        {
            string nome = GetText("Digite o Nome");
            Freguesia freguesia = RegistoFreguesiaController.PesquisarFreguesia(nome);
            if (freguesia != null)
            {
                Console.WriteLine(freguesia.ToString());
                Freguesia freguesiaAlterada = AlterarFreguesia(freguesia);
                RegistoFreguesiaController.AlterarFreguesia(freguesiaAlterada);
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }
            Menu();

        }
        private static void EliminarFreguesia()
        {
            string nome = GetText("Digite o Nome");
            Freguesia freguesia = RegistoFreguesiaController.EliminarFreguesia(nome);
            if (freguesia != null)
            {
                Console.WriteLine(freguesia.ToString());
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }
            Menu();

        }

        private static void PesquisarFreguesia()
        {
            string nome = GetText("Digite o Nome");
            Freguesia freguesia = RegistoFreguesiaController.PesquisarFreguesia(nome);
            if (freguesia != null)
            {
                Console.WriteLine(freguesia.ToString());
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }
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
                    freguesia.Nome = GetText("Nome");
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
                    freguesia.Nome = GetText("Nome");
                }
                catch (NomeFreguesiaInvalidoException e)
                {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
            return freguesia;
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

