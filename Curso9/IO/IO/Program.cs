using System;

namespace IO
{
    class Program
    {
        static void Main(string[] args) {
            //new LerStream().PrintDadosContaCorrente();

            new GravarStream().CriarArquivoComWriter();

            Console.ReadLine();
        }
    }
}
