using System;
using System.Runtime.Serialization;

namespace Exceptions
{
    class SaldoInsuficienteException : OperacaoFinanceiraException {
        public double Saldo { get; }
        public double ValorSaque{ get; }

        public SaldoInsuficienteException() {
        }

        public SaldoInsuficienteException(string message) : base(message) {
        }

        //Construtor personalizado
        public SaldoInsuficienteException(double saldo, double valorSaque)
            : this("Erro: saldo disponível "+saldo+", tentativa de saque: "+valorSaque) {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string message, Exception innerException)
            : base(message, innerException) {
        }
    }
}
