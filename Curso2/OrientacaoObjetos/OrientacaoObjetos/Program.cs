using System;

namespace OrientacaoObjetos
{
    class Program
    {
        static void Main(string[] args) {
            ContaCorrente cc = new ContaCorrente(123,98521);
            cc.Saldo = 10;

            //Ou

            ContaCorrente cc2 = new ContaCorrente(123, 98522) {
                Saldo = 20
            };

            Console.WriteLine("Saldo: " + cc.Saldo + ", Conta: " + cc.Conta);
            Console.WriteLine("Saldo: "+cc2.Saldo+", Conta: "+cc2.Conta);

            Console.WriteLine("Total de contas: " + ContaCorrente.TotalDeContasCriadas);

            Console.Read();
        }
    }
}
