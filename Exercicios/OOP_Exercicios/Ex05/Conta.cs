using System;

namespace Ex05
{
    class Conta 
    {
        public int NumeroConta { get; private set; }
        public string Nome;
        public double Saldo { get; private set; }

        public Conta(int numConta, string nome, double saldo) {
            NumeroConta = numConta;
            Nome = nome;
            Saldo = saldo;
        }

        public Conta(int numConta, string nome) {
            NumeroConta = numConta;
            Nome = nome;
            Saldo = 0;
        }

        public void Depositar(double valor) {
            Saldo += valor;
        }

        public void Sacar(double valor) {
            Saldo -= valor + 5;
        }

        public override string ToString() { 
            return $"Conta {NumeroConta}, Titular: {Nome}, Saldo: $ {Saldo:N2}";
        }
    }
}