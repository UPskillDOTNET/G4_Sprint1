using System;

namespace _4Source.views
{
    public class Menu
    {
        public static void mainMenu()
        {
            Utils.conPref();
            Utils.logo();

            do
            {
                int numInput;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\nBem vindo. Escolha a opção pretendida\n");
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.25));
                Console.ResetColor();
                Console.WriteLine("1) Gestão de Pessoas");
                Console.WriteLine("2) Gestão de Funcionários");
                Console.WriteLine("3) Gestão de Freguesias");
                Console.WriteLine("4) Gestão de Terrenos");
                Console.WriteLine("5) Gestão de Escritura");
                Console.WriteLine("6) Cálculo de Estatisticas");
                Console.WriteLine("\n7) Fechar Programa\n\n");




                do
                {
                   
                    numInput = Utils.GetIntNumber("Por favor escolha uma opção:");
                
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
                            GestaoEstatisticaUI.Menu();
                            break;
                        case 7:
                            Utils.menuExit();
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.Beep();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNúmero de input inválido, tente novamente.\n");
                            break;
                    }
                } while (numInput < 0 || numInput > 7);
            } while (true);
        }
    }
}