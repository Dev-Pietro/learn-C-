using System;

namespace Ex15.Entities.Exceptions
{
    class AmountException : ApplicationException
    {
        public AmountException(string message) : base(message) {} //criando o erro caso o valor do saque seja maior que o saldo
    }
}
