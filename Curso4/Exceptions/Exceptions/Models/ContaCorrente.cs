using Exceptions;
using System;

namespace OrientacaoObjetos
{
    class ContaCorrente {
        public Cliente Cliente { get; set; }

        //Transforma em readonly e só pode ser modificado no construtor
        public int Agencia { get; }
        public int Conta { get; }
        public int ContadorSaquesNaoPermitido { get; private set; }

        //Temos o Get publico e o Set privado
        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }

        private double _saldo; //_XXXX atributo privado da classe
        public double Saldo {
            get {
                return _saldo;
            }
            set {
                //Value Só funciona dentro do set
                if(value < 0) 
                    return;
                _saldo = value;
            }
        }

        //Construtor
        public ContaCorrente(int agencia, int conta) {

            if(agencia == 0)//Mensagem do erro e campo correspondente. O nameof pega o nome do atributo.
                throw new ArgumentException("A Agência deve ser maior que zero.", nameof(agencia));
            if(conta == 0)
                throw new ArgumentException("A Conta deve ser maior que zero.", nameof(conta));

            Agencia = agencia;
            Conta = conta;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void sacar(double valorSaque) {
            if(valorSaque <= 0)
                throw new ArgumentException("Quantia inválida para saque.", nameof(valorSaque));
            if(valorSaque > Saldo) {
                ContadorSaquesNaoPermitido++;
                throw new SaldoInsuficienteException(Saldo, valorSaque);
            }
            Saldo -= valorSaque;
        }
    }
}
