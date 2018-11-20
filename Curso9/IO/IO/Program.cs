using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class Program
    {
        static void Main(string[] args) {
            //Pega o caminho relativo à aplicação, dentro da pasta bin/debug/Dados.txt
            var filePath = "Dados.txt";

            FileStream fluxoDoArquivo = new FileStream(filePath, FileMode.Open);

            var buffer = new byte[128];
            var numeroDeBytesLidos = -1;

            while(numeroDeBytesLidos != 0) {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 128);
                printBuffer(buffer);
            }

            Console.ReadLine();
        }


        private static void printBuffer(byte[] buffer) {

            //Transforma o buffer em string
            var utf8 = Encoding.Default;
            var texto = utf8.GetString(buffer);

            Console.Write(texto);
        }
    }
}
