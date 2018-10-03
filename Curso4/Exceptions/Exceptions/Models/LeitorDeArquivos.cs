using System;

namespace Exceptions
{
    class LeitorDeArquivos
    {
        public string Arquivo { get; }

        public LeitorDeArquivos(string arquivo) {
            Arquivo = arquivo;
            Console.WriteLine("Abrindo arquivo: "+arquivo);
        }

        public string lerProximaLinha() {
            Console.WriteLine("Lendo próxima linha do arquivo.");
            return "linha do arquivo";
        }

        public void fechar() {

            Console.WriteLine("Fechando arquivo");
        }
    }
}
