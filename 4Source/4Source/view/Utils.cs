using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Source;

namespace _4Source.views
{
    public class Utils
    {
        public static int GetIntNumber(String label)
        {
            bool flag;
            int number = -1;
            string text;
            do
            {
                try
                {
                    flag = false;
                    text = GetText(label);
                    number = Convert.ToInt32(text);

                }
                catch (OverflowException)
                {
                    flag = true;
                }
                catch (FormatException)
                {
                    flag = true;
                }
            } while (flag);
            return number;
        }


        public static string GetText(string label)
        {
            string text = "";
            Console.Write(label + ": ");
            text = Console.ReadLine();
            return text;
        }

        public static DateTime GetDataNascimento() 
        {
            bool flag;
            DateTime dataNascimento;
            int ano = -1;
            int mes = -1;
            int dia = -1;
            do
            {
                try
                {
                    flag = false;
                    Console.Write("Introduza o ano: ");
                    ano = int.Parse(Console.ReadLine());
                }
                catch (AnoInvalidoException e)
                {
                    Console.WriteLine("Ano inválido" + e.ToString());
                    flag = true;
                }
                catch (FormatException)
                {
                    flag = true;
                }
            } while (flag);
            do
            {
                try
                {
                    flag = false;
                    Console.Write("Introduza o mês: ");
                    mes = int.Parse(Console.ReadLine());

                }
                catch (MesInvalidoException e)
                {
                    Console.WriteLine("Mês inválido" + e.ToString());
                    flag = true;
                }
            } while (flag);
            do
            {
                try
                {
                    flag = false;
                    Console.Write("Introduza o dia: ");
                    dia = int.Parse(Console.ReadLine());

                }
                catch (DiaInvalidoException e)
                {
                    Console.WriteLine("Dia inválido" + e.ToString());
                    flag = true;
                }
            } while (flag);

            dataNascimento = new DateTime(ano, mes, dia);
            return dataNascimento;
        }

        public static long GetLong(String label)
        {
            bool flag;
            long number = -1;
            string text;
            do
            {
                try
                {
                    flag = false;
                    text = GetText(label);
                    number = Convert.ToInt32(text);

                }
                catch (OverflowException)
                {
                    flag = true;
                }
                catch (FormatException)
                {
                    flag = true;
                }
            } while (flag);
            return number;
        }

        public static double GetDouble(String label)
        {
            bool flag;
            double number = 1.0;
            string text;
            do
            {
                try
                {
                    flag = false;
                    text = GetText(label);
                    number = Convert.ToDouble(text);

                }
                catch (OverflowException)
                {
                    flag = true;
                }
                catch (FormatException)
                {
                    flag = true;
                }
            } while (flag);
            return number;
        }

        public static IForma GetForma(String label)
        {
            Console.WriteLine("\n=== Que forma tem o terreno? ===\n\n");
            Console.WriteLine("1 - Triangular");
            Console.WriteLine("2 - Rectangular");
            Console.WriteLine("3 - Circular");

            string text = "";
            int number;
            bool flag;
            IForma forma;

            do
            {
                try
                {
                    flag = false;
                    text = GetText(label);
                    number = Convert.ToInt32(text);

                    switch (number)
                    {
                        case 1:
                            IForma forma = new Triangular();
                            break;
                        case 2:
                            IForma forma = new Rectangular();
                            break;
                        case 3:
                            IForma forma = new Circular();
                            break;
                        default:
                            Console.WriteLine("Nao DEU.");
                            break;
                    }

                }
                catch (OverflowException)
                {
                    flag = true;
                }
                catch (FormatException)
                {
                    flag = true;
                }
            } while (flag);
            return forma;
           
  
            //string input = GetText("Forma")
            //    switch (input) {

            //    case "triangular"
        }
    }
}