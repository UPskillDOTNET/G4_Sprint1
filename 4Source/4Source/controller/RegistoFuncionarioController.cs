using System;
using _4Source.persistencia;
using _4Source;
using System.Collections;
using System.Collections.Generic;

namespace _4Source.controllers
{
    public class RegistoFuncionarioController
    {
         public static bool RegistarFuncionario(Funcionario func)
        {
            bool flag = true;
            try
            {
                Autarquia autarquia = Dados.CarregarDados();
                autarquia.RegistarFuncionario(func);
                Dados.GuardarDados(autarquia);
            }
            catch (NifDuplicadoException e)
            {
                flag = false;
                Console.WriteLine("Advertencia: " + e.ToString());
            }
            return flag;
        }
   
        public static Funcionario EliminarFuncionario(string nr)
        {

            Funcionario func = null;
            try
            {
                Autarquia autarquia = Dados.CarregarDados();
                func = autarquia.EliminarFuncionario(nr);
                Dados.GuardarDados(autarquia);
            }
            catch (ElementoNaoExistenteException e)
            {

                Console.WriteLine("Advertencia: " + e.ToString());
            }
            return func;


        }
        public static Funcionario PesquisarFuncionario(string nr)
        {

            Funcionario func = null;
            Autarquia autarquia = Dados.CarregarDados();
            func = autarquia.PesquisarFuncionario(nr);
            return func;

        }
        public static List<Funcionario> ObterListaFuncionarios()
        {

            List<Funcionario> lista = null;

            Autarquia autarquia = Dados.CarregarDados();
            lista = autarquia.ObterTodosFuncionarios();
            return lista;

        }
    }
}
