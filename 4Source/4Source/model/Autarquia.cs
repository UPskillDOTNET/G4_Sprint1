using _4Source.model;
using _4Source.views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4Source
{
    [Serializable()]
    public class Autarquia
    {
        private string nome;
        private List<Pessoa> pessoaList;
        private List<Freguesia> freguesiaList;
        private List<Escritura> escrituraList;
        private int valorbase;

        public Autarquia(string nome, int valorbase)
        {
            this.Nome = nome;
            this.Valorbase = valorbase;
            this.PessoaList = new List<Pessoa>();
            this.FreguesiaList = new List<Freguesia>();
            this.EscrituraList = new List<Escritura>();
        }

        public Autarquia()
        {
            this.EscrituraList = new List<Escritura>();
        }
        // Properties - get and set.

        public int Valorbase { get => valorbase; set => valorbase = value; }

        public List<Freguesia> FreguesiaList { get => freguesiaList; set => freguesiaList = value; }

        public List<Pessoa> PessoaList { get => pessoaList; set => pessoaList = value; }

        public List<Escritura> EscrituraList { get => escrituraList; set => escrituraList = value; }

        public string Nome { get => nome; set => nome = value; }

        // Responsabilidade Pessoa

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

        //Obter todas Pessoas (Read)

        public List<Pessoa> ObterTodasPessoas()
        {
            return this.pessoaList;
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
            Console.WriteLine("A Pessoa abaixo foi eliminada");
            return pessoa;
        }


        //Criar Pessoa (Creator)
        public static Pessoa CriarPessoa()
        {
            Pessoa pessoa = new Pessoa();
            bool flag;

            do
            {
                try
                {
                    flag = false;
                    pessoa.Nif = Utils.GetText("NIF:");
                }
                catch (NifInvalidoException)
                {
                    flag = true;
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Atenção: NIF Invalido.");
                }
            } while (flag);
            do
            {
                try
                {
                    flag = false;
                    pessoa.Nome = Utils.GetText("Nome:");
                }
                catch (NomeInvalidoException )
                {
                    flag = true;
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Atenção: Nome Invalido.");
                }
            } while (flag);
            do
            {
                try
                {
                    flag = false;
                    pessoa.DataNascimento = Utils.GetDataNascimento();
                }
                catch (DataInvalidaException)
                {
                    flag = true;
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Atenção: Data Invalida.");
                }
            } while (flag);
            return pessoa;
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

        // Registar Freguesia (Creator)
        public static Freguesia CriarFreguesia()
        {
            Freguesia freguesia = new Freguesia();
            bool flag;
            do
            {
                try
                {
                    flag = false;
                    freguesia.Nome = Utils.GetText("Nome");
                }
                catch (NomeFreguesiaInvalidoException e)
                {
                    flag = true;
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Atenção: " + e.ToString());
                    Console.ResetColor();
                }
            } while (flag);
            return freguesia;
        }

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

        public List<Freguesia> ObterTodasFreguesias()
        {
            return this.freguesiaList;
        }

        //Editar Freguesia (Edit)

        public void AlterarFreguesia(Freguesia f, string nomeNovo)
        {
            Freguesia freguesia = GetFreguesiaByNome(f.Nome);
            freguesia.Nome = nomeNovo;
        }

        //Eliminar Freguesia (Delete)

        public Freguesia EliminarFreguesia(string nome)
        {
            Freguesia freguesia = GetFreguesiaByNome(nome);
            string tempnome;
            if (freguesia != null)
            {
                tempnome = nome;
                this.FreguesiaList.Remove(freguesia);
            }
            else
            {
                throw new ElementoNaoExistenteException(nome + " Não existe");
            }
            Console.WriteLine("A Freguesia abaixo foi eliminada");
            return freguesia;
        }

        // Responsabilidade Funcionario

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

        //Pesquisar Funcionario (Read)

        public Funcionario PesquisarFuncionario(string nr)
        {
            Funcionario func = GetFuncionarioByNr(nr);
            return func;
        }

        // Obter todos funcionarios (Read)

        public List<Funcionario> ObterTodosFuncionarios()
        {
            List<Funcionario> lista = new List<Funcionario>();
            foreach (Pessoa p in this.pessoaList)
            {
                if (p.GetType() == typeof(Funcionario))
                {
                    lista.Add((Funcionario)p);
                }
            }
            return lista;
        }

        // Eliminar Funcionario (Delete)

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

        //Responsabilidade Escritura

        public Escritura GetEscrituraByNum(int num)
        {

            foreach (Escritura e in EscrituraList)
            {
                if (e.Num == num)
                {
                    return e;
                }
            }
            return null;
        }

        //Criar Escritura (Create)

        public void RegistarEscritura(Escritura e)
        {

            string nome = Utils.GetText("Inserir o nome da freguesia a qual quer associar esta escritura:");
            Freguesia freguesia = GetFreguesiaByNome(nome);

            if (freguesia != null)
            {
                int id = Utils.GetIntNumber("Inserir o nome do terreno a qual quer associar esta escritura:");
                Terreno terreno = freguesia.GetTerrenoById(id);

                if (terreno != null)
                {
                    terreno.Escritura = e;
                    int numProprietarios = Utils.GetIntNumber("Quantos proprietários tem o terreno?");

                    for (int i = 0; i < numProprietarios; i++)
                    {
                        string prop = Utils.GetText("Introduza o NIF do proprietário :");
                        Pessoa pessoa = GetPessoaByNif(prop);
                        Proprietario teste = new Proprietario(pessoa);
                        e.ProprietariosList.Add(teste);
                        pessoa.TerrenosOwned++;
                    }

                }
                else
                {
                    throw new IdTerrenoInvalidoException(e.ToString() + "não existe na lista de terrenos");
                }
            }
            else
            {
                throw new NomeFreguesiaInvalidoException(e.ToString() + "não existe na lista de freguesias");
            }

            Escritura temp = GetEscrituraByNum(e.Num);
            if (temp == null)
            {
                this.EscrituraList.Add(e);

            }
            else
            {
                throw new EscrituraDuplicadoException(e.ToString() + "Número já existente");
            }

        }


        //Pesquisar Escritura (Read)

        public Escritura PesquisarEscritura(int num)
        {

            string nome = Utils.GetText("Inserir o nome da freguesia da escritura associada:");
            Freguesia freguesia = GetFreguesiaByNome(nome);

            if (freguesia != null)
            {
                int id = Utils.GetIntNumber("Inserir o nome do terreno da escritura associada:");
                Terreno terreno = freguesia.GetTerrenoById(id);

                if (terreno != null)
                {

                    Escritura escritura = GetEscrituraByNum(num);
                    return escritura;
                }
            }
            return null;
        }
        // Obter todas escrituras (Read)

        public List<Escritura> ObterTodasEscrituras()
        {
            return this.EscrituraList;
        }

        //Eliminar Escritura (Delete)

        public Escritura EliminarEscritura(int num)
        {
            string nome = Utils.GetText("Inserir o nome da freguesia da escritura associada:");
            Freguesia freguesia = GetFreguesiaByNome(nome);

            if (freguesia != null)
            {
                int id = Utils.GetIntNumber("Inserir o nome do terreno da escritura associada:");
                Terreno terreno = freguesia.GetTerrenoById(id);

                if (terreno != null)
                {
                    Escritura escritura = GetEscrituraByNum(num);
                    if (escritura != null)
                    {
                        this.EscrituraList.Remove(escritura);
                    }
                    else
                    {
                        throw new ElementoNaoExistenteException(num + " Não existe");
                    }
                }

            }
            return null;
        }
        // Responsabilidades de calculo de estatisticas

        public List<Pessoa> MostrarPessoasDeterminadaData(DateTime data)
        {
            List<Pessoa> list = new List<Pessoa>();

            foreach (Pessoa p in pessoaList)
            {
                DateTime.Compare(data, p.DataNascimento);
                if (data > p.DataNascimento)
                {
                    list.Add(p);
                }

            }
            return list;
        }

        // Sort as 5 pessoas mais velhas

        public List<Pessoa> MostrarTop5PessoasMaisVelhas()
        {

            List<Pessoa> PessoaList = this.PessoaList;
            List<Pessoa> SortedList = PessoaList.OrderBy(p => p.DataNascimento).Take(5).ToList();

            return SortedList;

        }

        public double MostrarAreaTotalAutarquia()
        {

            double areaTotal = 0;

            foreach (Freguesia f in freguesiaList)
            {
                foreach (Terreno t in f.TerrenoList)
                {
                    areaTotal += t.Forma.CalcArea();
                }
            }
            return areaTotal;
        }

        public double MostrarPercentagemAreaRuralAutarquia()
        {
            double areaRural = 0;

            foreach (Freguesia f in freguesiaList)
            {
                foreach (Terreno t in f.TerrenoList)
                {
                    if (t.Classificacao.GetClassificacao() == "Rural")
                    {
                        areaRural += t.Forma.CalcArea();
                    }
                }
            }
            return areaRural;
        }

        public string MostrarAreaPredominanteFreguesia(Freguesia f)
        {
            List<Terreno> mydata = new List<Terreno>();
            foreach (Terreno t in f.TerrenoList)
            {
                if (t.Classificacao.GetClassificacao() == "Rural")
                {
                    mydata.Add(t);
                }
            }
            var query = mydata.GroupBy(x => x.Classificacao.GetUso())
                    .Select(group => new { DescUso = group.Key, Count = group.Count() })
                    .OrderByDescending(x => x.Count);
            string descUso = query.First().DescUso;
            return descUso;
        }


        public List<Pessoa> MostrarTopProprietarios()
        {

            List<Pessoa> PessoaList = this.PessoaList;
            List<Pessoa> SortedList = PessoaList.OrderByDescending(p => p.TerrenosOwned).Take(5).ToList();

            return SortedList;

        }

        public List<Freguesia> CalcContriAutarquia()
        {
            List<Freguesia> FreguesiaList = this.FreguesiaList;

            foreach (Freguesia f in FreguesiaList)
            {
                foreach (Terreno t in f.TerrenoList)
                {
                    if (t.Classificacao.GetClassificacao() == "Urbana")
                    {
                        f.ContriAuto += t.Classificacao.GetIndiceCont() * valorbase;
                    }
                }
            }

            List<Freguesia> SortedList = FreguesiaList.OrderByDescending(f => f.ContriAuto).ToList();

            return SortedList;
        }

        public List<Terreno> MostrarListaTerrenosInspecao(DateTime data, string nome)
        {
            List<Terreno> mydata = new List<Terreno>();
            Freguesia freguesia = GetFreguesiaByNome(nome);

            foreach (Terreno t in freguesia.TerrenoList)
            {
                if (t.Classificacao.GetClassificacao() == "Industrial")
                {
                    DateTime.Compare(data, t.Classificacao.GetData());
                    if (data > t.Escritura.Data)
                    {
                        mydata.Add(t);
                    }

                }
            }
            return mydata;
        }

        public List<Freguesia> MostrarFreguesiasDimensao()
        {
            List<Freguesia> newList = new List<Freguesia>();

            foreach (Freguesia f in freguesiaList)
            {
                foreach (Terreno t in f.TerrenoList)
                {
                    f.DimensaoTotal += t.Forma.CalcArea();
                }
                newList.Add(f);
            }
            List<Freguesia> teste = newList.OrderByDescending(f => f.DimensaoTotal).ToList();
            return teste;
        }

    }
}