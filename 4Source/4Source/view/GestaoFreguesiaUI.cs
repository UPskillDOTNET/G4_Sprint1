using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.views
{
    class GestaoFreguesiaUI
    {
        public static void MainFreguesia()
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

