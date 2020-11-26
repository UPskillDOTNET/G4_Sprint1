using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.views
{
    class GestaoEstatisticaUI
    {
        public static void MainEstatistica()
        {

        }

        public static void Menu()
        {
            switch (Console.ReadLine())
            {
                case "1":
                    //criarPessoa();
                    break;
                case "2":
                    //editarPessoa();
                    break;
                case "3":
                    //listarPessoa();
                    break;
                case "4":
                    //eliminarPessoa();
                    break;
                case "5":
                    //voltarMenuPrincipal();
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    break;
            }
        }
    }
}
}
