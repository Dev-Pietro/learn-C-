using System;

namespace Ex15.Entities.Exceptions
{
    class WithDrawLimitException : ApplicationException
    {
        public WithDrawLimitException(string message) : base(message) {} //criando erro caso o valor de saque seja maior que o limite
    }
}
