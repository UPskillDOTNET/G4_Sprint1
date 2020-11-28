using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.views
{
    public class Menu
    {

        public static void mainMenu()
        {

            do
            {
                int numInput;
                Console.Clear();
                Console.WriteLine("Bem vindo. Escolha a opção pretendida\n\n");
                Console.WriteLine("1) Gestão de Pessoa.");
                Console.WriteLine("2) Gestão de Funcionários");
                Console.WriteLine("3) Gestão de Freguesias.");
                Console.WriteLine("4) Gestão de Terrenos");
                Console.WriteLine("5) Cálculo de Estatisticas");
                Console.WriteLine("6) Fechar Programa\n\n");

               
                numInput = Utils.GetIntNumber("Por favor escolha uma opção: \n");

                do
                {
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
                            //GestaoEstatisticaUI.MainEstatistica();
                            break;
                        case 6:
                            Console.WriteLine("Obrigado por usar 4Source.");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Número de input inválido, tente novamente.");
                            // Sair fora deste loop, pedir novamente o input.
                            break;
                            
                    }

                } while (numInput < 0 || numInput > 6);
            } while (true);



        }
    }
}