using IO.Models;
using System.IO;

namespace IO
{
    class GravarStream
    {
        public void CriarArquivoComWriter() {
            //Endereço relativo bin/debug/
            var filePath = "DadosExportados.csv";

            //Grava os dados
            using(var fluxo = new FileStream(filePath, FileMode.Append))
            using(var writer = new StreamWriter(fluxo)) {
                writer.Write("123,75464,548.94, Usuário padrão Stream Writer");

                //libera o buffer
                writer.Flush();
            }
        }


        public void CriarArquivoBinario() {
            var filePath = "DadosBinarios.data";

            using(var fluxo = new FileStream(filePath, FileMode.Create))
            using(var binWriter = new BinaryWriter(fluxo)) {
                binWriter.Write(123);
                binWriter.Write(456);
                binWriter.Write(789.99);
                binWriter.Write("User default binary Writer");
            }
        }
    }
}
