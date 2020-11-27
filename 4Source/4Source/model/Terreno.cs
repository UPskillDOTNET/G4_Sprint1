using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _4Source
{
    public class Terreno
    {
        private int id;
        private double indiceCont;
        private string forma;
        private double area;
        private double imi;

        public Terreno()
        {

        }
        public Terreno(int id, double indiceCont, string forma, double area, double imi)
        {
            this.id = id;
            this.indiceCont = indiceCont;
            this.forma = forma;
            this.area = area;
            this.imi = imi;
            
        }


        public int Id   // property
        {
            get { return id; }   // get method
            set { id = value; } 
        }

        public double IndiceCont   // property
        {
            get { return indiceCont; }
            set { indiceCont = value; }
        }
        public double Area   // property
        {
            get { return area; }
            set { area = value; }
        }
        public double Imi  // property
        {
            get { return imi; }
            set { imi = value; }
        }   
        private static bool ValidaId(int id)
        {
            Regex regex = new Regex("^[1-9]\\d*$", RegexOptions.IgnoreCase);
            string idstring = id.ToString();
            Match m = regex.Match(idstring);

            if (!m.Success)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}


