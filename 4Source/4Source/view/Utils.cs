using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4Source;
using System.Text.RegularExpressions;

namespace _4Source.views
{
    public class Utils
    {
        public static int GetIntNumber(String label)
        {
            bool flag;
            int number = -1;
            string text;
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.25));
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(label + " ");
            Console.ResetColor();
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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Introduza o ano: ");
                    Console.ResetColor();
                    ano = int.Parse(Console.ReadLine());
                   
                }
                catch (AnoInvalidoException e)
                {
                    Console.Beep();
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ano inválido" + e.ToString());
                    Console.ResetColor();
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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Introduza o mês: ");
                    Console.ResetColor();
                    mes = int.Parse(Console.ReadLine());
              

                }
                catch (MesInvalidoException e)
                {
                    Console.Beep();
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Mês inválido" + e.ToString());
                    Console.ResetColor();
                    flag = true;
                }
            } while (flag);
            do
            {
                try
                {
                    flag = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Introduza o dia: ");
                    Console.ResetColor();
                    dia = int.Parse(Console.ReadLine());

                }
                catch (DiaInvalidoException e)
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dia inválido" + e.ToString());
                    Console.ResetColor();
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
            Console.ForegroundColor = ConsoleColor.Yellow;
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


        public static DateTime GetData()
        {
            bool flag;
            DateTime data;
            int ano = -1;
            int mes = -1;
            int dia = -1;
            
            do
            {
                try
                {
                    flag = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Introduza o ano: ");
                    Console.ResetColor();


                    ano = int.Parse(Console.ReadLine());
                }
                catch (AnoInvalidoException e)
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ano inválido" + e.ToString());
                    Console.ResetColor();

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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Introduza o mês: ");
                    Console.ResetColor();
                    mes = int.Parse(Console.ReadLine());

                }
                catch (MesInvalidoException e)
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Mês inválido" + e.ToString());
                    Console.ResetColor();
            
                    flag = true;
                }
            } while (flag);
            do
            {
                try
                {
                    flag = false;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Introduza o dia: ");
                    Console.ResetColor();
                    dia = int.Parse(Console.ReadLine());

                }
                catch (DiaInvalidoException e)
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Dia inválido" + e.ToString());
                    Console.ResetColor();
                    flag = true;
                }
            } while (flag);
            
            data = new DateTime(ano, mes, dia);
            return data;
        }

        public static void menuExit()
        {
            Console.Clear();
            string title = @"


                                           Obrigado e um bem Haja da 4source                                           ";
            string tittle2 = @"
 
                             Caio Reis                                           João Martins              
                             Mariana Gomes                                       Tiago Azevedo             
                             Sergio Pinto                                                                   ";


            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(title);
            Console.ResetColor();
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(0.75));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(tittle2);
            Console.ResetColor();
        }

        public static void logo()
        {

            string title = @"









                              ██╗  ██╗    ███████╗ ██████╗ ██╗   ██╗██████╗  ██████╗███████╗
                              ██║  ██║    ██╔════╝██╔═══██╗██║   ██║██╔══██╗██╔════╝██╔════╝";

            string title2 = @"                              ███████║    ███████╗██║   ██║██║   ██║██████╔╝██║     █████╗  
                              ╚════██║    ╚════██║██║   ██║██║   ██║██╔══██╗██║     ██╔══╝  
                                   ██║    ███████║╚██████╔╝╚██████╔╝██║  ██║╚██████╗███████╗
                                   ╚═╝    ╚══════╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═╝ ╚═════╝╚══════╝                                      
                               ";
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(title2);
            Console.ResetColor();
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2.5));




        }

        public static void conPref() {
            
            
            Console.Title = ("4Source - we make what you want us to make by your definition of making");
            Console.WriteLine("Default Title: {0}",
                             Console.Title);

            Console.CursorSize = 1;
            ConsoleHelper.SetCurrentFont("Everson Mono", 15);
            Console.Clear();

         }




    public static string ValidarNif(string label)
        {
            Regex regex = new Regex(" ^\\d{9}$", RegexOptions.IgnoreCase);
            Match m = regex.Match(label);

            do
            {

                string text = "";
                Console.Write(label + " ");
                text = Console.ReadLine();


                if (!m.Success)
                {
                    return text;
                    
                }


            } while (true);

        }
    }
}


