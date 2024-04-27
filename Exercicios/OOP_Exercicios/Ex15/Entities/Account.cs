using System;
using Ex15.Entities.Exceptions;


namespace Ex15.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > Balance)
            {
                throw new AmountException("Withdraw error: Not enough balance"); //throw - joga o erro na tela, no caso oque foi criado no exemplo
            } else if (amount > WithDrawLimit)
            {
                throw new WithDrawLimitException("Withdraw error: The amount exceeds withdraw limit"); //jogando na tela o erro de withdraw limit
            }

            Balance -= amount;
        }
    }
}
