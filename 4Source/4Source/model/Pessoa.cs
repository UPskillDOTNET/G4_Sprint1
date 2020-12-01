using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections;
using System.Globalization;
using _4Source.views;

namespace _4Source
{
    [Serializable()]
    public class Pessoa //: IComparer
    {
        private string nome;
        private string nif;
        private DateTime dataNascimento;
        private int terrenosOwned;


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
                    throw new NomeInvalidoException("Nome inválido");
                }
            }
        }
        public string Nif   // property
        {
            get { return nif; }   // get method
            set
            {
                if (ValidarNif(value))
                {
                    nif = value;

                }
                else
                {
                    throw new NifInvalidoException("NIF inválido");
                }
            }
        }

        public DateTime DataNascimento   // property
        {
            get { return dataNascimento; }   // get method
            set
            {
                if (ValidarAno(value) <= 0)
                {
                    dataNascimento = value;
                }
                else
                {
                    throw new DataInvalidaException("Data inválida");
                }
            }
        }

        public int TerrenosOwned { get => terrenosOwned; set => terrenosOwned = value; }

        public Pessoa(string nome, string nif, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.Nif = nif;
            this.DataNascimento = dataNascimento.Date;
            this.terrenosOwned = 0;
        }

        public Pessoa()
        {

        }

        public override string ToString()
        {
            return "NIF: " + Nif + "\nNome: " + Nome + "\nData de nascimento: " + DataNascimento.ToString("dd/MM/yyyy");
        }

        private static bool ValidarNome(string nome)
        {
            Regex regex = new Regex("^[a-zA-Z]{3,24}$", RegexOptions.IgnoreCase);
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

        private static bool ValidarNif(string nif)
        {
            Regex regex = new Regex("^\\d{9}$", RegexOptions.IgnoreCase);
            Match m = regex.Match(nif);

            if (!m.Success)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static int ValidarAno(DateTime ano)
        {
             return DateTime.Compare(ano, DateTime.Today);

        }

        public static Funcionario CriarFuncionario()
        {
            Funcionario func = new Funcionario();
            Pessoa pessoa = Autarquia.CriarPessoa();
            func.Nif = pessoa.Nif;
            func.Nome = pessoa.Nome;
            func.DataNascimento = pessoa.DataNascimento;
            bool flag;
            do
            {
                try
                {
                    flag = false;
                    func.numeroFunc = Utils.GetText("Numero:");
                }
                catch (NumeroFuncionarioInvalidoException e)
                {
                    flag = true;
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Atenção: " + e.ToString());
                    Console.ResetColor();
                }
            } while (flag);
            func.Cargo = Utils.GetText("Cargo:");
            return func;
        }
    }
}
