using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args) {
            try {
                carregarContas();
            } catch(Exception) {
                Console.WriteLine("Exception capturada no método main.");
            }
            Console.ReadLine();
        }

        private static void carregarContas() {
            //equivalente ao try with resources
            using(LeitorDeArquivos leitor = new LeitorDeArquivos("arquivo")) {
                leitor.lerProximaLinha();
                leitor.lerProximaLinha();
            }
        }
    }
}
