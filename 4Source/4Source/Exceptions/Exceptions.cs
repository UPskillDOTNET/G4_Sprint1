using System;

namespace _4Source {
    public class DataInvalidaException : Exception {
        public DataInvalidaException(string message) : base(message) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Data Introduzida Invalida");
            Console.ResetColor();
        }
    }
    public class NifInvalidoException : Exception {
        public NifInvalidoException(string message) : base(message) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NIF Invalido");
            Console.ResetColor();
        }
    }
    public class NomeInvalidoException : Exception {
        public NomeInvalidoException(string message) : base(message) {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nome Invalido");
            Console.ResetColor();
        }
    }
    public class NumeroFuncionarioInvalidoException : Exception {
        public NumeroFuncionarioInvalidoException(string message) : base(message) {
        }
    }

    public class IdTerrenoInvalidoException : Exception {
        public IdTerrenoInvalidoException(string message) : base(message) { }
    }

    public class NomeDuplicadoException : Exception {
        public NomeDuplicadoException(string message) : base(message) { }
    }

    public class IdDuplicadoException : Exception {
        public IdDuplicadoException(string message) : base(message) {
        }
    }

    public class TerrenoDuplicadoException : Exception {
        public TerrenoDuplicadoException(string message) : base(message) {
        }
    }

    public class FormaTerrenoInvalidaException : Exception {
        public FormaTerrenoInvalidaException(string message) : base(message) {
        }
    }

    public class IndiceTerrenoInvalidoException : Exception {
        public IndiceTerrenoInvalidoException(string message) : base(message) {
        }
    }

    public class EscrituraDuplicadoException : Exception {
        public EscrituraDuplicadoException(string message) : base(message) {
        }
    }

    public class NumeroEscrituraInvalidoException : Exception
    {
        public NumeroEscrituraInvalidoException(string message) : base(message)
        {
        }
    }

    public class DataEscrituraInvalidoException : Exception
    {
        public DataEscrituraInvalidoException(string message) : base(message)
        {
        }
    }

    public class FreguesiaDuplicadoException : Exception {
        public FreguesiaDuplicadoException(string message) : base(message) {
        }
    }

    public class NomeFreguesiaInvalidoException : Exception {
        public NomeFreguesiaInvalidoException(string message) : base(message) {

        }
    }

    public class NifDuplicadoException : Exception {
        public NifDuplicadoException(string message) : base(message) {
        }
    }
    public class NumeroFuncionarioDuplicadoException : Exception {
        public NumeroFuncionarioDuplicadoException(string message) : base(message) {
        }
    }
    public class ElementoNaoExistenteException : Exception {
        public ElementoNaoExistenteException(string message) : base(message) {
        }
    }

    public class NomePessoaInvalidoException : Exception {
        public NomePessoaInvalidoException(string message) : base(message) {
        }
    }

    public class AnoInvalidoException : Exception
    {
        public AnoInvalidoException(string message) : base(message)
        {
        }
    }

    public class MesInvalidoException : Exception
    {
        public MesInvalidoException(string message) : base(message)
        {
        }
    }

    public class DiaInvalidoException : Exception
    {
        public DiaInvalidoException(string message) : base(message)
        {
        }
    }

}