using System;
using System.Collections;
using _4Source.persistencia;
using _4Source;

namespace _4Source.controllers {
    class RegistoEscrituraController
    {

        public static bool RegistarEscritura(Escritura escritura)
    {
        bool flag = true;
        try
        {
            Autarquia autarquia = Dados.CarregarDados();
            autarquia.RegistarEscritura(escritura);
            Dados.GuardarDados(autarquia);
        }
        catch (EscrituraDuplicadoException e)
        {
            flag = false;
            Console.WriteLine("Atenção: " + e.ToString());
        }
        return flag;
    }

    public static Escritura PesquisarEscritura(int num)
    {

        Escritura escritura = null;
        Autarquia autarquia = Dados.CarregarDados();
        escritura = autarquia.PesquisarEscritura(num);
        return escritura;

    }

    public static ArrayList ObterListaEscrituras()
    {

        ArrayList lista = null;

        Autarquia autarquia = Dados.CarregarDados();
        lista = autarquia.ObterTodasEscrituras();
        return lista;

    }

        public static Escritura EliminarEscritura(int num)
    {

        Escritura escritura = null;
        try
        {
            Autarquia autarquia = Dados.CarregarDados();
            escritura = autarquia.EliminarEscritura(num);
            Dados.GuardarDados(autarquia);
        }
        catch (ElementoNaoExistenteException e)
        {

            Console.WriteLine("Atenção: " + e.ToString());
        }
        return escritura;
    }
}
}

