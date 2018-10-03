namespace OrientacaoObjetos
{
    class ContaCorrente {
        public Cliente Cliente { get; set; }
        public int Agencia { get; set; }
        public int Conta { get; set; }

        public static double TaxaOperacao { get; private set; }

        //Get public e set private
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
            Agencia = agencia;
            Conta = conta;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }
    }
}
