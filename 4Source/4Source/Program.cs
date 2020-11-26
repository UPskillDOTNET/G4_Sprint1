using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Source.views;

namespace _4Source
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.mainMenu();
            Console.ReadKey();
        }
    }
}
