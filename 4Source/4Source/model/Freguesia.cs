using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
using _4Source.views;

namespace _4Source
{
    [Serializable()]
    public class Freguesia 
    {
        private string nome;
        private List<Terreno> terrenoList;
        private double dimensaoTotal;
        private double contriAuto;


        public string Nome   // property
        {
            get { return nome; }   // get method
            set
            {
                if (ValidarNome(value))
                {
                    nome = value;
                }
                else
                {
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nome inválido");
                    Console.ResetColor();
                    Console.ReadKey();
                }
            }
        }


        private static bool ValidarNome(string nome)
        {
            Regex regex = new Regex(@"^([a-zA-Z]\w{3,14})+(\s([a-zA-Z]\w{1,28})+)*$", RegexOptions.IgnoreCase);
            Match m = regex.Match(nome);
           
            if (!m.Success)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        public Freguesia(string nome)
        {
            this.Nome = nome;
            this.terrenoList = new List<Terreno>();
        }

        public Freguesia()
        {
            this.terrenoList = new List<Terreno>();
        }
        
        public override string ToString()
        {
            return "Nome da freguesia: " + nome + "\nNúmero de Terrenos: " + terrenoList.Count;
        }

 
        public List<Terreno> TerrenoList { get => terrenoList; set => terrenoList = value; }
        public double ContriAuttotal { get; set; }
       
        public double DimensaoTotal { get => dimensaoTotal; set => dimensaoTotal = value; }
        public double ContriAuto { get => contriAuto; set => contriAuto = value; }

        public void RegistarTerreno(Terreno t)
        {

            Terreno temp = GetTerrenoById(t.Id);
            if (temp == null)
            {
                    this.terrenoList.Add(t);
            }else
            {
                throw new IdDuplicadoException(t.ToString() + "Id já existente");
            }
        }

        public Terreno PesquisarTerreno(int id)
        {
            Terreno terreno = GetTerrenoById(id);
            return terreno;
        }

        public Terreno EliminarTerreno(int id)
        {
            Terreno terreno = GetTerrenoById(id);
            if (terreno != null)
            {
                this.terrenoList.Remove(terreno);
            }
            else
            {
                throw new ElementoNaoExistenteException(id + " Não existe");
            }
            return terreno;
        }

        public List<Terreno> ObterTodosTerrenos()
        {
            return this.TerrenoList;
        }

        public Terreno GetTerrenoById(int id)
        {
     
            foreach (Terreno t in TerrenoList)
            {
                if (t.Id == id)
                {
                    return t;
                }
            }
            return null;
        }


        //Criar Terreno (creator)
        public static Terreno CriarTerreno()
        {
            Terreno terreno = new Terreno();
            bool flag;
            do
            {
                try
                {
                    flag = false;
                    terreno.Id = Utils.GetIntNumber("ID");
                }
                catch (IdTerrenoInvalidoException e)
                {
                    flag = true;
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Atenção: " + e.ToString());
                    Console.ResetColor();
                }
            } while (flag);

            do
            {
                flag = false;
                int number = Utils.GetIntNumber("Que forma tem o terreno?\n1 - Triangular\n2 - Rectangular\n3 - Circular\n");
                switch (number)
                {
                    case 1:

                        terreno.Forma = GetAreaTri();
                        break;
                    case 2:
                        terreno.Forma = GetAreaRect();
                        break;
                    case 3:
                        terreno.Forma = GetAreaCirc();
                        break;
                    default:
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erro. Opção inválida");
                        Console.ResetColor();
                        flag = true;
                        break;
                }
            } while (flag);

            do
            {
                flag = false;
                int number = Utils.GetIntNumber("Que Classificação possui o terreno?\n1 - Rural\n2 - Urbana\n3 - Industrial\n");
                switch (number)
                {
                    case 1:
                        terreno.Classificacao = GetRural();
                        break;
                    case 2:
                        terreno.Classificacao = GetUrbana(terreno.Forma.CalcArea());
                        break;
                    case 3:
                        terreno.Classificacao = GetIndustrial(terreno.Forma.CalcArea());
                        break;
                    default:
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erro. Opção inválida");
                        Console.ResetColor();
                        flag = true;
                        break;
                }
            } while (flag);

            return terreno;
        }



        private static Triangular GetAreaTri()
        {
            double largura, comprimento;
            do
            {
                largura = Utils.GetDouble("Qual a largura do Terreno?");
                comprimento = Utils.GetDouble("Qual o comprimento do Terreno?");
            } while (largura <= 0 || comprimento <= 0);
            return new Triangular(largura, comprimento);
        }
        private static Rectangular GetAreaRect()
        {
            double largura, comprimento;
            do
            {
                largura = Utils.GetDouble("Qual a largura do Terreno?");
                comprimento = Utils.GetDouble("Qual o comprimento do Terreno?");
            } while (largura <= 0 || comprimento <= 0);
            return new Rectangular(largura, comprimento);
        }
        private static Circular GetAreaCirc()
        {
            double diametro;
            do
            {
                diametro = Utils.GetDouble("Qual o valor do diametro do Terreno?");

            } while (diametro <= 0);
            return new Circular(diametro / 2);
        }

        private static Rural GetRural()
        {
            double indiceCont;
            string descUso;
            do
            {
                indiceCont = Utils.GetDouble("Qual o indice de contribuição do Terreno? (Entre 0 e 1):\n");
            } while (indiceCont < 0 || indiceCont > 1);
            do
            {
                descUso = Utils.GetText("Qual a atividade rural do Terreno? ");

            } while (false);

            return new Rural(indiceCont, descUso);
        }
        private static Urbana GetUrbana(double area)
        {
            double indiceCont;
            string tipologia;
            double areaConst;
            DateTime dataConst;

            do
            {
                indiceCont = Utils.GetDouble("Qual o indice de contribuição do Terreno? (Entre 0 e 1)");
            } while (indiceCont < 0 || indiceCont > 1);
            do
            {
                areaConst = Utils.GetDouble("Qual a area da construção?");
            } while (areaConst > area || areaConst < 0);
            do
            {
                tipologia = Utils.GetText("Qual a tipologia da construção?");
                dataConst = Utils.GetData();

            } while (false);
            return new Urbana(indiceCont, tipologia, areaConst, dataConst, area);
        }

        private static Industrial GetIndustrial(double area)
        {
            double indiceCont;
            string desc;
            string tipologia;
            double areaConst;
            DateTime dataConst;
            DateTime dataInsp;
            string descInsp;
            do
            {
                indiceCont = Utils.GetDouble("Qual o indice de contribuição do Terreno? (Entre 0 e 1)");
            } while (indiceCont < 0 || indiceCont > 1);
            do
            {
                areaConst = Utils.GetDouble("Qual a area da construção? ");
            } while (areaConst > area || areaConst < 0);
            do
            {

                desc = Utils.GetText("Qual a principal atividade industrial do terreno? ");
                tipologia = Utils.GetText("Qual a tipologia da construção? ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Qual a data de Construção? ");
                Console.ResetColor();
                dataConst = Utils.GetData();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Qual a data da ultima Inspeção? ");
                Console.ResetColor();
                dataInsp = Utils.GetData();
                descInsp = Utils.GetText("Descrição do relatório da Inspeção: ");
                Console.ResetColor();

            } while (false);
            return new Industrial(indiceCont, desc, tipologia, areaConst, dataConst, dataInsp, descInsp, area);
        }


       
      
    }

}
