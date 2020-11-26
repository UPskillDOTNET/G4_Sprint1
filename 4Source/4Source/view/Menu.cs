using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.views
{
    public class Menu
    {

        public void mainMenu()
        {
            Console.Clear();
            Console.WriteLine("Bemvindo user. Escolha a opção pretendida\n");
            Console.WriteLine("1) Gestão de Pessoa.");
            Console.WriteLine("2) Gestão de Funcionários");
            Console.WriteLine("3) Gestão de Freguesias.");
            Console.WriteLine("4) Cálculo de Estatisticas");
            Console.WriteLine("5) Fechar Programa");

            switch (Console.ReadLine())
            {
                case "1":
                    GestaoPessoaUI.Menu();
                    break;
                case "2":
                    GestaoFuncionarioUI.MainFuncionario();
                    break;
                case "3":
                    GestaoFreguesiaUI.MainFreguesia();
                    break;
                case "4":
                    GestaoEstatisticaUI.MainEstatistica();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
        }
    }
}
