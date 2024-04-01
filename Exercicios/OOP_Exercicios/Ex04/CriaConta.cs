using System;

namespace Ex04
{
    class CriaConta
    {
        public string nome;
        public string senha;
        public double saldo = 0;

        public void Depositar(double valor) {
            saldo += valor;
        }

        public void Sacar(double valor) {
            saldo -= valor;
        }

        public override string ToString() {
            return $"INFORMAÇÕES DA CONTA\nNome do Usúario: {nome} \nSenha: {senha}\nSaldo: R${saldo:N2}";
        }
    }
}