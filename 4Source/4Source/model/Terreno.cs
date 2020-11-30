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



        // private void adicionarEscritura(Escritura e) {
        // this.Escritura = e;

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


