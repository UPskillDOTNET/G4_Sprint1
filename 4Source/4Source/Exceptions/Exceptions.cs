﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4Source.Exceptions {
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