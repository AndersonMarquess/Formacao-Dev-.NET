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
            }
        }
    }
}
