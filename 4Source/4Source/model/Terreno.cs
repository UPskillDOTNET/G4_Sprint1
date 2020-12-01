using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using _4Source.views;

namespace _4Source
{
    [Serializable()]
    public class Terreno
    {
        private int id;
        private IForma forma;
        private IClassificacao classificacao;
        private Escritura escritura;

        public Terreno()
        {
            this.escritura = new Escritura();
        }
        public Terreno(int id, IForma forma, IClassificacao classificacao, Escritura escritura)
        {
            this.Id = id;
            this.forma = forma;
            this.Classificacao = classificacao;
            this.Escritura = escritura;

        }

        public override string ToString()
        {
            return String.Format("\n\nID do Terreno: {0} \n Indice de Contribuição: {1} \n {2}\n Área: {3} \n\n{4}\n IMI:{5}", Id, Classificacao.GetIndiceCont(), forma.GetForma(), forma.CalcArea(), Classificacao.ToString(), Classificacao.CalcIMI());
        }

        public int Id { get => id; set => id = value; }
        public IForma Forma { get => forma; set => forma = value; }
        public Escritura Escritura { get => escritura; set => escritura = value; }
        public IClassificacao Classificacao { get => classificacao; set => classificacao = value; }

        public static Escritura CriarEscritura()
        {
            Escritura escritura = new Escritura();
            bool flag;
            do
            {
                try
                {
                    flag = false;
                    escritura.Num = Utils.GetIntNumber("Numero de Escritura:");
                }
                catch (NumeroEscrituraInvalidoException e)
                {
                    flag = true;
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
            do
            {
                try
                {
                    flag = false;
                    escritura.Data = Utils.GetData();
                }
                catch (DataEscrituraInvalidoException e)
                {
                    flag = true;
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Atenção: " + e.ToString());
                }
            } while (flag);
            return escritura;
        }






    }
}


