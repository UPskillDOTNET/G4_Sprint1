using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine(label + ": ");
            text = Console.ReadLine();
            return text;
        }

        public static DateTime GetDataNascimento() 
        {
            bool flag;
            string text;
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



        //Console.Write("Introduza o ano: ");
        //    int ano = int.Parse(Console.ReadLine());
        //    Console.WriteLine("mes");
        //    int mes = int.Parse(Console.ReadLine());
        //    Console.WriteLine("dia");
        //    int dia = int.Parse(Console.ReadLine());
        //    DateTime data = new DateTime(ano, mes, dia);
        //    return data;
        //}

        //DateTime.Compare(dateNascimento, DateTime.Now());

    }
}