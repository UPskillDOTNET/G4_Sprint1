using System;

namespace _4Source {
    public class DataInvalidaException : Exception {
        public DataInvalidaException(string message) : base(message) {
        }
    }
    public class NifInvalidoException : Exception {
        public NifInvalidoException(string message) : base(message) {
        }
    }
    public class NomeInvalidoException : Exception {
        public NomeInvalidoException(string message) : base(message) {
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

    public class EscrituraDuplicadoException : Exception {
        public EscrituraDuplicadoException(string message) : base(message) {
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


}