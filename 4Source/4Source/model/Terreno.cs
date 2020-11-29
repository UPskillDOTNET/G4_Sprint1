using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _4Source
{
    [Serializable()]
    public class Terreno
    {
        private int id;
        private double indiceCont;
        private double imi;
        private IForma forma;
        public IClassificacao classificacao;
        private Escritura escritura;

        public Terreno()
        {

        }
        public Terreno(int id, double indiceCont, IForma forma, IClassificacao classificacao, double imi, Escritura escritura)
        {
            this.Id = id;
            this.IndiceCont = indiceCont;
            this.forma = forma;
            this.classificacao = classificacao;
            this.Imi = imi;
            this.Escritura = escritura;

        }

        public override string ToString()
        {
            return String.Format("\n\nID do Terreno: {0} \n Indice de Contribuição: {1} \n {2}\n Área: {3} \n\n{4}\n", Id, IndiceCont, forma.GetForma(), forma.CalcArea(), classificacao.GetClassificacao());
        }

        public int Id { get => id; set => id = value; }
        public double IndiceCont { get => indiceCont; set => indiceCont = value; }
        public double Imi { get => imi; set => imi = value; }
        public IForma Forma { get => forma; set => forma = value; }
        public Escritura Escritura { get => escritura; set => escritura = value; }
        
        
        //private static bool ValidaId(int id)
        //{
        //    Regex regex = new Regex("^[1-9]\\d*$", RegexOptions.IgnoreCase);
        //    string idstring = id.ToString();
        //    Match m = regex.Match(idstring);

        //    if (!m.Success)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    }
}


