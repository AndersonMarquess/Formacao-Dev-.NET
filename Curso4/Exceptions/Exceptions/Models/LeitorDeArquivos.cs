using System;
using System.IO;

namespace Exceptions
{
    class LeitorDeArquivos : IDisposable //Funciona igual ao AutoCloseable
    {
        public string Arquivo { get; }

        public LeitorDeArquivos(string arquivo) {
            Arquivo = arquivo;
            //throw new FileNotFoundException("O arquivo: "+arquivo+" não foi encontrado.");
            Console.WriteLine("Abrindo arquivo: "+arquivo);
        }

        public string lerProximaLinha() {
            Console.WriteLine("Lendo próxima linha do arquivo.");
            //throw new IOException();
            return "linha do arquivo";
        }

        public void fechar() {
            Console.WriteLine("Fechando arquivo");
        }

        //Libera os recursos
        public void Dispose() {
            fechar();
        }
    }
}
