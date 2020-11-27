using System;
using System.Collections;
using _4Source;
using _4Source.persistencia;

namespace _4Source.controllers
{
    public class RegistoPessoaController
    {
        public static bool RegistarPessoa(Pessoa pessoa)
        {
            bool flag = true;
            try
            {
                Autarquia autarquia = Dados.CarregarDados();
                autarquia.RegistarPessoa(pessoa);
                Dados.GuardarDados(autarquia);
            }
            catch (NifDuplicadoException e)
            {
                flag = false;
                Console.WriteLine("Advertencia: " + e.ToString());
            }
            return flag;
        }

        public static Pessoa PesquisarPessoa(string nif)
        {
            Pessoa pessoa = null;
            Autarquia autarquia = Dados.CarregarDados();
            pessoa = autarquia.PesquisarPessoa(nif);
            return pessoa;
        }

        public static bool AlterarPessoa(Pessoa pessoa)
        {
            bool flag = true;
            try
            {
                Autarquia autarquia = Dados.CarregarDados();
                autarquia.AlterarPessoa(pessoa);
                Dados.GuardarDados(autarquia);
            }
            catch (ElementoNaoExistenteException e)
            {
                flag = false;
                Console.WriteLine("Advertencia: " + e.ToString());
            }
            return flag;
        }

        public static Pessoa EliminarPessoa(string nif)
        {

            Pessoa pessoa = null;
            try
            {
                Autarquia autarquia = Dados.CarregarDados();
                pessoa = autarquia.EliminarPessoa(nif);
                Dados.GuardarDados(autarquia);
            }
            catch (ElementoNaoExistenteException e)
            {

                Console.WriteLine("Advertencia: " + e.ToString());
            }
            return pessoa;
        }

        public static ArrayList ObterListaPessoas()
        {

            ArrayList lista = null;

            Autarquia autarquia = Dados.CarregarDados();
            lista = autarquia.ObterTodasPessoas();
            //Dados.GuardarDados(autarquia);
            return lista;

        }
    }
}
