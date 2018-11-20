﻿using IO.Models;
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

                    Console.WriteLine(ParseLinhaParaContaCorrente(linha));
                    Console.WriteLine("=================");
                }
            }


            Console.ReadLine();
        }

        private static ContaCorrente ParseLinhaParaContaCorrente(string linha) {
            var dados = linha.Split(' ');

            int agencia = Convert.ToInt32(dados[0]);
            int conta = Convert.ToInt32(dados[1]);
            double saldo = Convert.ToDouble(dados[2].Replace(".",","));
            string titular = dados[3];

            return new ContaCorrente(agencia, conta, titular, saldo);
        }
    }
}
