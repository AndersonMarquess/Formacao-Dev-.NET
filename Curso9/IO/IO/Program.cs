using System;

namespace IO
{
    class Program
    {
        static void Main(string[] args) {
            var ls = new LerStream();
            //ls.PrintDadosContaCorrente();
            ls.PrintDadosBinarios();

            //var gs = new GravarStream();
            //gs.CriarArquivoComWriter();
            //gs.CriarArquivoBinario();

            Console.ReadLine();
        }
    }
}
