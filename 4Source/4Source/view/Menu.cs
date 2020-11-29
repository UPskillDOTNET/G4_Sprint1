using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace _4Source.views
{
    public class Menu
    {

        public static void mainMenu()
        {
            Console.Title = ("4Source - we make what you want us to make by your defenition of making");
            Console.WriteLine("Default Title: {0}",
                             Console.Title);
      
            Console.CursorVisible = false;
            ConsoleHelper.SetCurrentFont("Everson Mono", 15);




            do
            {
                int numInput;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\nBem vindo. Escolha a opção pretendida\n");
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.ResetColor();
                Console.WriteLine("1) Gestão de Pessoas.");
                Console.WriteLine("2) Gestão de Funcionários");
                Console.WriteLine("3) Gestão de Freguesias.");
                Console.WriteLine("4) Gestão de Terrenos");
                Console.WriteLine("5) Gestão de Escritura");
                Console.WriteLine("6) Cálculo de Estatisticas");
                Console.WriteLine("7) Fechar Programa\n\n");
                

                do
                {
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    numInput = Utils.GetIntNumber("Por favor escolha uma opção:");
                    Console.ResetColor();
                    switch (numInput)
                    {
                        case 1:
                            GestaoPessoaUI.Menu();
                            break;
                        case 2:
                            GestaoFuncionarioUI.Menu();
                            break;
                        case 3:
                            GestaoFreguesiaUI.Menu();
                            break;
                        case 4:
                            GestaoTerrenoUI.Menu();
                            break;
                        case 5:
                            GestaoEscrituraUI.Menu();
                            break;
                        case 6:
                            //GestaoEstatisticaUI.Menu();
                        case 7:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.WriteLine("\nObrigado por usar 4Source.");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNúmero de input inválido, tente novamente.\n");
                            break;
                    }
                } while (numInput < 0 || numInput > 7);
            } while (true);



        }
    }
}