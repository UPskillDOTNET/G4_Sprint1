using _4Source.controllers;
using System;
using System.Collections;

namespace _4Source.views {
    class GestaoEscrituraUI {

        public static void Menu() {
            int numInput;
            Console.Clear();
            Console.WriteLine("\n=== Gestão de Escrituras ===\n\n");
            Console.WriteLine("1 - Registar Escritura");
            Console.WriteLine("2 - Pesquisar Escritura");
            Console.WriteLine("3 - Editar Escritura");
            Console.WriteLine("4 - Eliminar Escritura");
            Console.WriteLine("5 - Mostrar Lista de Escrituras");
            Console.WriteLine("6 - Voltar ao Menu Principal");
            Console.WriteLine("===========================\n");
            numInput = Utils.GetIntNumber("Por favor escolha uma opção:");

            do {
                switch (numInput) {
                    case 1:
                        RegistarEscritura();
                        break;
                    case 2:
                        PesquisarEscritura();
                        break;
                    case 3:
                        AlterarEscritura();
                        break;
                    case 4:
                        EliminarEscritura();
                        break;
                    case 5:
                        ListarEscrituras();
                        break;
                    case 6:
                        Console.WriteLine("\nVolta para o menu anterior.\n");
                        Console.ReadKey();
                        views.Menu.mainMenu();
                        break;
                    default:
                        Console.WriteLine("\nOpção errada. Escolha novamente.\n");
                        Menu();
                        break;
                }
            } while (numInput != 6);
        }

        private static void ListarEscrituras() {
            ArrayList lista = RegistoEscrituraController.ObterListaEscrituras();
            foreach (Escritura escritura in lista) {
                Console.WriteLine(escritura.ToString());
            }
            Console.ReadKey();
            Menu();
        }


        private static void AlterarEscritura() {
            string nif = Utils.GetText("Digite o NIF:");
            Escritura escritura = RegistoEscrituraController.PesquisarEscritura(nif);
            if (escritura != null) {
                Console.WriteLine(escritura.ToString());
                Escritura escrituraAlterada = AlterarEscritura(escritura);
                RegistoEscrituraController.AlterarEscritura(escrituraAlterada);
            } else {
                Console.WriteLine("Não existe!!!");
            }
            Menu();

        }
        private static void EliminarEscritura() {
            string nif = Utils.GetText("Digite o NIF:");
            Escritura escritura = RegistoEscrituraController.EliminarEscritura(nif);
            if (escritura != null) {
                Console.WriteLine(escritura.ToString());
            } else {
                Console.WriteLine("Não  existe!!!");
            }
            Menu();

        }

        private static void PesquisarEscritura() {
            string nif = Utils.GetText("Digite o NIF:");
            Escritura escritura = RegistoEscrituraController.PesquisarEscritura(nif);
            if (escritura != null) {
                Console.WriteLine(escritura.ToString());
            } else {
                Console.WriteLine("Não existe!!!");
            }
            Console.ReadKey();
            Menu();
        }

        private static void RegistarEscritura() {
            Escritura escritura = CriarEscritura();
            RegistoEscrituraController.RegistarEscritura(escritura);
            Menu();
        }

        public static Escritura CriarEscritura() {
            Escritura escritura = new Escritura();
            bool flag;
            do {
                try {
                    flag = false;
                    escritura.Nif = Utils.GetText("NIF:");
                } catch (NifInvalidoException e) {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
            do {
                try {
                    flag = false;
                    escritura.Nome = Utils.GetText("Nome");
                } catch (NomeEscrituraInvalidoException e) {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
            do {
                try {
                    flag = false;
                    escritura.DataNascimento = Utils.GetDataNascimento();
                } catch (NomeEscrituraInvalidoException e) {
                    flag = true;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
            return escritura;
        }

        public static void CalcularPercentagem() {
            Console.WriteLine("Quantos proprietários tem o terreno?");
            int numProprietarios = int.Parse(Console.ReadLine());
            double percentagem = 0;
            double totalPercentagem = 0;
            double[] array = new double[numProprietarios];
            int count = 1;

            for (int i = 0; i < numProprietarios; i++) {
                Console.WriteLine("Introduza a percentagem do proprietario:");
                percentagem = double.Parse(Console.ReadLine());
                array[i] = percentagem;
                totalPercentagem += percentagem;
            }
            foreach (double perc in array) {

                Console.WriteLine("O proprietário {0} possui {1} % do terreno", count, perc);
                count += 1;
            }
            double sum = array.Sum();
            Console.WriteLine("Posse total dos proprietários em relação ao terreno: {0} ", sum);

        }
    }
}
