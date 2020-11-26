using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.view
{
    class RegistoTerrenoUI
    {
        public void registarPessoa()
        {
            Console.WriteLine("Opçao 1 selecionada");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Introduza o nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Introduza o nif");
            string nif = Console.ReadLine();
            Console.WriteLine("NIF: {0}", nif);
            Console.WriteLine("Introduza a data de nascimento");
            string data = Console.ReadLine();
            Console.WriteLine("Data: {0}", data);
        }
    }
}
