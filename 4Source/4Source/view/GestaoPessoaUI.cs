using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.views
{
    class GestaoPessoaUI
    {
      
        public static void Menu()
        {
            Console.WriteLine("\n=== Gestão de Pessoas ===");
            Console.WriteLine("1 - Registar Pessoa");
            Console.WriteLine("2 - Pesquisar Pessoa");
            Console.WriteLine("3 - Editar Pessoa");
            Console.WriteLine("4 - Eliminar Pessoa");
            Console.WriteLine("5 - Mostrar lista de Pessoas");
            Console.WriteLine("\n6 - Voltar ao Menu Principal");
            int input = int.Parse(Console.ReadLine());
            do
            {
                switch (input)
                {
                    case 1:
                        //CriarPessoa();
                        break;
                    case 2:
                        //PesquisarPessoa();
                        break;
                    case 3:
                        //EditarPessoa();
                        break;
                    case 4:
                        //EliminarPessoa();
                        break;
                    case 5:
                        //MostrarListaPessoa();
                    case 6:
                        //VoltarMenuPrincipal();
                        break;
                    default:
                        Console.WriteLine("Opção errada. Escolha novamente.");
                        break;
                }
            } while (input != 0);
        }
        //public static Pessoa CriarPessoa() { }
        //public static PesquisarPessoa() { }
        //public static EditarPessoa() { }
        //public static EliminarPessoa() { }
        //public static MostrarListaPessoa() { }
        //public static VoltarMenuPrincipal() { }
    }
}
