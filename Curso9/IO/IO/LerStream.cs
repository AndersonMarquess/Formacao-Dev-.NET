using IO.Models;
using System;
using System.IO;

namespace IO
{
    class LerStream
    {
        public void PrintDadosContaCorrente() {
            //Pega o caminho relativo à aplicação, dentro da pasta bin/debug/Dados.txt
            var filePath = "Dados.txt";


            using(var fluxoDoArquivo = new FileStream(filePath, FileMode.Open))
            using(var leitor = new StreamReader(fluxoDoArquivo)) {
                while(!leitor.EndOfStream) {
                    var linha = leitor.ReadLine();

                    Console.WriteLine(ParseLinhaParaContaCorrente(linha));
                    Console.WriteLine("=================");
                }
            }
        }

        public ContaCorrente ParseLinhaParaContaCorrente(string linha) {
            var dados = linha.Split(',');

            int agencia = Convert.ToInt32(dados[0]);
            int conta = Convert.ToInt32(dados[1]);
            double saldo = Convert.ToDouble(dados[2].Replace(".", ","));
            string titular = dados[3];

            return new ContaCorrente(agencia, conta, titular, saldo);
        }

        public void PrintDadosBinarios() {
            var filePath = "DadosBinarios.data";

            using(var fluxo = new FileStream(filePath, FileMode.Open))
            using(var binReader = new BinaryReader(fluxo)) {

                var conta = binReader.ReadInt32();
                var agencia = binReader.ReadInt32();
                var saldo = binReader.ReadDouble();
                var titular = binReader.ReadString();

                Console.WriteLine($"Titular: {titular} \nAgência: {agencia} \nConta: {conta} \nSaldo: {saldo}");
            }
        }
    }
}
