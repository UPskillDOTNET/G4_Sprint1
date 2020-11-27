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
    }
}