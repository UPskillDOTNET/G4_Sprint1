using System;
using System.Collections;
using System.Collections.Generic;
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
            catch (NifDuplicadoException)
            {
                flag = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("Advertencia: Nif já existente. Porfavor escolha uma nova opção" );
                Console.ReadKey();
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

        public static Pessoa AlterarPessoa(Pessoa pessoa)
        {
            try
            {
                Autarquia autarquia = Dados.CarregarDados();
                Pessoa updatedPessoa = autarquia.AlterarPessoa(pessoa);
                Dados.GuardarDados(autarquia);
            }
            catch (ElementoNaoExistenteException e)
            {
                Console.WriteLine("Advertencia: " + e.ToString());
            }
            return pessoa;
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

        public static List<Pessoa> ObterListaPessoas()
        {

            List<Pessoa> lista = null;

            Autarquia autarquia = Dados.CarregarDados();
            lista = autarquia.ObterTodasPessoas();
            return lista;

        }
    }
}
