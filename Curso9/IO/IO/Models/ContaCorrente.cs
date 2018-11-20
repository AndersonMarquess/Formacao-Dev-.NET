using System;

namespace IO.Models
{
    class ContaCorrente
    {
        public int Agencia { get; private set; }
        public int Conta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaCorrente(int agencia, int conta, string titular, double saldo = 0.0d) {
            if(agencia < 0 || conta < 0)
                throw new ArgumentException($"A {Agencia} ou {Conta} não pode ter um valor menor que 0.");

            Agencia = agencia;
            Conta = conta;
            Saldo = saldo;
            Titular = titular;
        }

        public string Sacar(double valor) {
            if(valor < 0 || valor > Saldo)
                return "Valor indisponível.";

            Saldo -= valor;
            return "Saque realizado com sucesso!";
        }

        public void depositar(double valor) {
            if(valor < 0)
                throw new ArgumentException("Valor indisponível.");

            Saldo += valor;
        }

        public override string ToString() {
            return $"Titular: {Titular} \nAgência: {Agencia} \nConta: {Conta} \nSaldo: {Saldo}";
        }
    }
}
