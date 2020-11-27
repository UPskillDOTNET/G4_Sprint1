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
                Console.Clear();
                Console.WriteLine("Bem vindo. Escolha a opção pretendida\n");
                Console.WriteLine("1) Gestão de Pessoa.");
                Console.WriteLine("2) Gestão de Funcionários");
                Console.WriteLine("3) Gestão de Freguesias.");
                Console.WriteLine("4) Cálculo de Estatisticas");
                Console.WriteLine("5) Fechar Programa");
                int numInput = Int32.Parse(Console.ReadLine());

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
                            //GestaoEstatisticaUI.MainEstatistica();
                            break;
                        case 5:
                            Console.WriteLine("Bye!!!");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Wrong option");
                            break;
                    }

                } while (numInput < 0 || numInput > 5);
            } while (true);



        }
    }
}