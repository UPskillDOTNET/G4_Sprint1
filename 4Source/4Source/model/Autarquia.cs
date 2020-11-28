using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace _4Source
{
    [Serializable()]
    public class Autarquia
    {
        private string nome;
        private ArrayList pessoaList;
        private ArrayList freguesiaList;
        private ArrayList escrituraList;
        private int valorbase;

        public Autarquia(string nome, int valorbase)
        {
            this.Nome = nome;
            this.Valorbase = valorbase;
            this.PessoaList = new ArrayList();
            this.FreguesiaList = new ArrayList();
        }

        // Responsabilidade Pessoa

        public int Valorbase { get => valorbase; set => valorbase = value; }
        
        public ArrayList FreguesiaList { get => freguesiaList; set => freguesiaList = value; }
        
        public ArrayList PessoaList { get => pessoaList; set => pessoaList = value; }

        public ArrayList EscrituraList { get => escrituraList; set => escrituraList = value; }

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

        //Obter todas Pessoas

        public ArrayList ObterTodasPessoas()
        {
            return this.pessoaList;
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

        //Validação Nome
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
        // Registar Freguesia (Create)
        public void RegistarFreguesia(Freguesia f)
        {
            Freguesia temp = GetFreguesiaByNome(f.Nome);
            if (temp == null)
            {
                this.FreguesiaList.Add(f);

            }
            else
            {
                throw new NomeDuplicadoException(f.ToString() + "Nome já existente");
            }

        }

        //Pesquisar Freguesia (Read)
        public Freguesia PesquisarFreguesia(string nome)
        {
            Freguesia freguesia = GetFreguesiaByNome(nome);
            return freguesia;
        }

        public ArrayList ObterTodasFreguesias() {
            return this.freguesiaList;
        }

        //Editar Freguesia (Edit)
        public void AlterarFreguesia(Freguesia f)
        {
            Freguesia freguesia = GetFreguesiaByNome(f.Nome);
            freguesia.Nome = f.Nome;
        }

        //Eliminar Freguesia (Delete)
        public Freguesia EliminarFreguesia(string nome)
        {
            Freguesia freguesia = GetFreguesiaByNome(nome);
            if (freguesia != null)
            {
                this.FreguesiaList.Remove(freguesia);
            }
            else
            {
                throw new ElementoNaoExistenteException(nome + " Não existe");
            }
            Console.WriteLine("A freguesia {0} foi eliminada do sistema", nome);
            return freguesia;
        }

        public Freguesia GetFreguesiaByNome(string nome)
        {

            foreach (Freguesia f in FreguesiaList)
            {
                if (f.Nome == nome)
                {
                    return f;
                }
            }
            return null;
        }

        //Registar Funcionario (Create)
        public void RegistarFuncionario(Funcionario p)
        {

            Pessoa temp = GetPessoaByNif(p.Nif);
            if (temp == null)
            {
                Funcionario temp1 = GetFuncionarioByNr(p.numeroFunc);
                if (temp1 == null)
                {
                    this.pessoaList.Add(p);
                }
                else
                {
                    throw new NumeroFuncionarioDuplicadoException(p.ToString() + " O número está duplicado");
                }
            }
            else
            {
                throw new NifDuplicadoException(p.ToString() + " O NIF está duplicado");
            }
        }

        public Funcionario PesquisarFuncionario(string nr)
        {
            Funcionario func = GetFuncionarioByNr(nr);
            return func;
        }

        public Funcionario EliminarFuncionario(string nr)
        {
            Funcionario func = GetFuncionarioByNr(nr);
            if (func != null)
            {
                this.pessoaList.Remove(func);
            }
            else
            {
                throw new ElementoNaoExistenteException(nr + " Não existe");
            }
            return func;
        }

        public ArrayList ObterTodosFuncionarios()
        {
            ArrayList lista = new ArrayList();
            foreach (Pessoa p in this.pessoaList)
            {
                if (p.GetType() == typeof(Funcionario))
                {
                    lista.Add(p);
                }
            }
            return lista;
        }

        Funcionario GetFuncionarioByNr(string numeroFunc)
        {
            Funcionario f = null;
            foreach (Object obj in this.pessoaList)
            {
                if (obj.GetType() == typeof(Funcionario))
                {
                    f = (Funcionario)obj;
                    if (f.numeroFunc == numeroFunc)
                    {
                        return f;
                    }
                }
            }
            return null;
        }

        ////Responsabilidade Escritura
        ////Criar Escritura (Create)
        //public void RegistarEscritura(Escritura e) {
        //    Escritura temp = GetEscrituraByNum(e.Num);
        //    if (temp == null) {
        //        this.EscrituraList.Add(e);

        //    } else {
        //        throw new EscrituraDuplicadoException(e.ToString() + "Número já existente");
        //    }

        //}

        ////Pesquisar Escritura (Read)
        //public Escritura PesquisarEscritura(int num) {
        //    Escritura escritura = GetEscrituraByNum(num);
        //    return escritura;
        //}

        ////Eliminar Escritura (Delete)
        //public Escritura EliminarEscritura(int num) {
        //    Escritura escritura = GetEscrituraByNum(num);
        //    if (escritura != null) {
        //        this.EscrituraList.Remove(escritura);
        //    } else {
        //        throw new ElementoNaoExistenteException(num + " Não existe");
        //    }
        //    return escritura;
        //}

        //public Escritura GetEscrituraByNum(int num) {

        //    foreach (Escritura e in EscrituraList) {
        //        if (e.Num == num) {
        //            return e;
        //        }
        //    }
        //    return null;
        //}
    }
}