using System;

namespace ExeAula155.Entities.Exceptions
{
    class DomainException : ApplicationException //herda caracteristicas da ApplicationException
    {
        public DomainException(string message) : base(message) //método trás a msg de erro em string, acessando o message da classe ApplicationException
        {
        }
    }
}
