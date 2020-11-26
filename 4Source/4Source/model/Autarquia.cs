using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace _4Source
{
    class Autarquia
    {
        private string nome;
        private ArrayList pessoaList;
        private ArrayList freguesias;
        private int valorbase;

        public Autarquia(string nome, int valorbase)
        {
            this.Nome = nome;
            this.Valorbase = valorbase;
            this.PessoaList = new ArrayList();
            this.Freguesias = new ArrayList();
        }

        // Responsabilidade Pessoa
        public override string ToString()
        {
            Freguesia p;
            string str = "Nome: " + this.Nome + "\n";
            foreach (Object obj in this.PessoaList)
            {
                p = (Freguesia)obj;
                str += "\t" + p.ToString() + "\n";
            }
            return str;
        }
   
        public int Valorbase { get => valorbase; set => valorbase = value; }
        
        public ArrayList Freguesias { get => freguesias; set => freguesias = value; }
        
        public ArrayList PessoaList { get => pessoaList; set => pessoaList = value; }
        
        public string Nome { get => nome; set => nome = value; }

        //Criar Pessoa (Create)
        public void RegistarPessoa(Pessoa p)
        {
            Pessoa temp = GetPessoaByNif(p.Nif);
            if (temp == null)
            {
                this.PessoaList.Add(p);

            }
            else
            {
                throw new NifDuplicadoException(p.ToString() + "Nif já existente");
            }

        }
                
        //Pesquisar Pessoa (Read)
        public Pessoa PesquisarPessoa(string nif)
        {
            Pessoa pessoa = GetPessoaByNif(nif);
            return pessoa;
        }

        //Editar Pessoa (Edit)
        public void AlterarPessoa(Pessoa p)
        {
            Pessoa pessoa = GetPessoaByNif(p.Nif);
            pessoa.Nif = p.Nif;
            pessoa.Nome = p.Nome;
            pessoa.DataNascimento = p.DataNascimento;
        }

        //Eliminar Pessoa (Delete)
        public Pessoa EliminarPessoa(string nif)
        {
            Pessoa pessoa = GetPessoaByNif(nif);
            if (pessoa != null)
            {
                this.PessoaList.Remove(pessoa);
            }
            else
            {
                throw new ElementoNaoExistenteException(nif + " Não existe");
            }
            return pessoa;
        }

        public Pessoa GetPessoaByNif(string nif)
        {

            foreach (Pessoa p in PessoaList)
            {
                if (p.Nif == nif)
                {
                    return p;
                }
            }
            return null;
        }

        //Validação Pessoa
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

        // Responsabilidade Freguesia

    }
}