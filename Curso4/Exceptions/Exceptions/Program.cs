using OrientacaoObjetos;
using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args) {
            ContaCorrente cc = new ContaCorrente(123, 45621);
            Console.WriteLine("Valor da taxa: " + ContaCorrente.TaxaOperacao);

            testaDivisao(10);

            Console.ReadLine();
        }

        private static void testaDivisao(int divisor) {
            try {
                int result = dividir(10, divisor);
                Console.WriteLine("O Resultado de 10 dividido por " + divisor + " = " + result);
            } catch(Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                throw; // Encerra o método passando a exception recebida
            }
        }

        private static int dividir(int numero, int divisor) {
            ContaCorrente c = null;
            Console.WriteLine(c.Cliente.Cpf);

            return numero / divisor;
        }
    }
}
