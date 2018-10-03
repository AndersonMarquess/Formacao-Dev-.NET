using OrientacaoObjetos;
using System;

namespace Exceptions
{
    class TestaExceptionContaCorrente
    {

        public static void Main(string[] args) {

            try {
                ContaCorrente cc = new ContaCorrente(123, 01);
                cc.sacar(50);
            } catch(SaldoInsuficienteException e) {
                Console.WriteLine(e.Saldo);
                Console.WriteLine(e.ValorSaque);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            } catch(Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            try {
                Console.WriteLine("Valor da taxa: " + ContaCorrente.TaxaOperacao);
                testaDivisao(10);

            } catch(NullReferenceException e) {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        private static void testaDivisao(int divisor) {
            try {
                int result = dividir(10, divisor);
                Console.WriteLine("O Resultado de 10 dividido por " + divisor + " = " + result);
            } catch(Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                throw e; // Encerra o método passando a exception recebida
            }
        }

        private static int dividir(int numero, int divisor) {
            ContaCorrente c = null;
            Console.WriteLine(c.Cliente.Cpf);

            return numero / divisor;
        }
    }
}
