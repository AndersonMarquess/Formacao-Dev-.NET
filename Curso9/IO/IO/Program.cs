using System;
using System.IO;
using System.Text;

namespace IO
{
    class Program
    {
        static void Main(string[] args) {
            //Pega o caminho relativo à aplicação, dentro da pasta bin/debug/Dados.txt
            var filePath = "Dados.txt";


            using(var fluxoDoArquivo = new FileStream(filePath, FileMode.Open))
            using(var leitor = new StreamReader(fluxoDoArquivo)) {
                while(!leitor.EndOfStream) {
                    var linha = leitor.ReadLine();
                    Console.WriteLine(linha);
                }
            }


            Console.ReadLine();
        }
    }
}
