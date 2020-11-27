using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Source.controllers;


namespace _4Source.views
{
    class GestaoTerrenoUI
    {
        public static void MainTerreno()
        {

            Console.WriteLine("\nMenu Terreno");
            Console.WriteLine("1 - Inserir Terreno");
            Console.WriteLine("2 - Listar Terreno");
            Console.WriteLine("3 - Eliminar Terreno");
            Console.WriteLine("4 - Listar Terrenos");
            Console.WriteLine("\n0 - Voltar\n");
            int numInput = Int32.Parse(Console.ReadLine());
            do
            {
                switch (numInput)
                {
                    case 0:
                        Console.WriteLine("\nVolta para o menu anterior.");
                        break;
                    case 1:
                        RegistarTerreno();
                        break;
                    case 2:
                        PesquisarTerreno();
                        break;
                    case 3:
                        EliminarTerreno();
                        break;
                    case 4:
                        ListarTerrenos();
                        break;
                    default:
                        Console.WriteLine("\nOpção Errada");
                        break;
                }

            } while (numInput != 0);

        }
        private static void ListarTerrenos()
        {
            string nome = GetText("Digite o nome da Freguesia");
            ArrayList lista = RegistoTerrenoController.ObterListaTerrenos(nome);
            foreach (Terreno terreno in lista)
            {
                Console.WriteLine(terreno.ToString());
            }
        }

        private static void EliminarTerreno()
        {
            string nome = GetText("Digite o nome da Freguesia");
            int id = GetIntNumber("Digite o ID");
            Terreno terreno = RegistoTerrenoController.EliminarTerreno(nome, id);
            if (terreno != null)
            {
                Console.WriteLine(terreno.ToString());
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }

        }

        private static void PesquisarTerreno()
        {
            string nome = GetText("Digite o Nome da Freguesia");
            int id = GetIntNumber("Digite o Id");
            Terreno terreno = RegistoTerrenoController.PesquisarTerreno(nome, id);
            if (terreno != null)
            {
                Console.WriteLine(terreno.ToString());
            }
            else
            {
                Console.WriteLine("Não  existe!!!");
            }

        }
        private static void RegistarTerreno()
        {
            string nome = GetText("Digite o Nome da Freguesia");
            Terreno terreno = CriarTerreno();
            RegistoTerrenoController.RegistarTerreno(nome, terreno);

        }

        public static Terreno CriarTerreno()
        {
            Terreno terreno = new Terreno();
            bool flag;
            do
            {
                try
                {
                    flag = false;
                    terreno.Id = GetIntNumber("ID");
                }
                catch (IdTerrenoInvalidoException e)
                {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
            return terreno;
        }
        public static Terreno AlterarTerreno(Terreno terreno)
        {
            bool flag;

            do
            {
                try
                {
                    flag = false;
                    terreno.Id = GetIntNumber("ID: ");
                }
                catch (IdTerrenoInvalidoException e)
                {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
            return terreno;
        }
        public static string GetText(string label)
        {
            string text = "";
            Console.WriteLine(label + ": ");
            text = Console.ReadLine();
            return text;
        }
        public static int GetIntNumber(String label)
        {
            bool flag;
            int number = -1;
            string text;
            do
            {
                try
                {
                    flag = false;
                    text = GetText(label);
                    number = Convert.ToInt32(text);

                }
                catch (OverflowException)
                {
                    flag = true;
                }
                catch (FormatException)
                {
                    flag = true;
                }
            } while (flag);
            return number;
        }
    }
}
