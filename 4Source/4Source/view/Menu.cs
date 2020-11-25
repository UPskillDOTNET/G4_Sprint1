using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source
{
    public class Menu
    {

        public void mainMenu()
        {
            Console.Clear();
            Console.WriteLine("Bemvindo user. Escolha a opção pretendida\n");
            Console.WriteLine("1) Registar uma pessoa.");
            Console.WriteLine("2) Registar uma freguesia.");
            Console.WriteLine("3) Registar um terreno.");
            Console.WriteLine("4) Registar uma escritura");
            Console.WriteLine("5) Fechar Programa");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Escolheu 1");
                    //registarPessoa();
                    break;
                case "2":
                    Console.WriteLine("Escolheu 2");
                    //registarFreguesia();
                    break;
                case "3":
                    Console.WriteLine("Escolheu 3");
                    //registarTerreno();
                    break;
                case "4":
                    Console.WriteLine("Escolheu 4");
                    //registarEscritura();
                    break;
                case "5":
                    break;
                default:
                    break;

            }
        }
    }
}
