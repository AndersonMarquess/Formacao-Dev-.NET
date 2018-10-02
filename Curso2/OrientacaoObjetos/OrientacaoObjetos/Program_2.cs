using OrientacaoObjetos.Models;
using System;

namespace OrientacaoObjetos
{
    class Program_2 {

        static void Main(string[] args) {

            GerenciadorBonificacoes gb = new GerenciadorBonificacoes();

            Funcionario f1 = new Funcionario {
                Nome = "Nome 1",
                CPF = "123.456.789-99",
                Salario = 2150
            };
            gb.registrar(f1);

            Funcionario d1 = new Diretor {
                Nome = "Nome 2",
                CPF = "999.876.543-21",
                Salario = 5210
            };
            gb.registrar(d1);

            Console.WriteLine("Funcionario bonificação: " + f1.getBonificacao());
            Console.WriteLine("Diretor bonificação: " + d1.getBonificacao());
            Console.WriteLine("Total de bonificações: " + gb.totalBonificacoes);

            Console.ReadLine();
        }
    }
}
