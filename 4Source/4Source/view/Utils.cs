using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Source.view
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
            Console.WriteLine("ano");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("mes");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("dia");
            int dia = int.Parse(Console.ReadLine());
            DateTime data = new DateTime(ano, mes, dia);
            return data;
        }
         
    }
}