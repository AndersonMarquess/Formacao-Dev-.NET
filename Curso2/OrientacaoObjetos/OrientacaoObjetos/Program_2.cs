using OrientacaoObjetos.Models;
using System;

namespace OrientacaoObjetos
{
    class Program_2 {

        static void Main(string[] args) {

            GerenciadorBonificacoes gb = new GerenciadorBonificacoes();

            Funcionario f1 = new Designer("123.456.789-99") {
                Nome = "Nome 1"
            };
            gb.registrar(f1);

            Funcionario d1 = new Diretor("999.876.543-21") {
                Nome = "Nome 2"
            };
            gb.registrar(d1);

            Console.WriteLine("Funcionario bonificação: " + f1.getBonificacao());
            Console.WriteLine("Diretor bonificação: " + d1.getBonificacao());
            Console.WriteLine("Total de bonificações: " + gb.totalBonificacoes);
            Console.WriteLine("Total de funcionarios criados: "+Funcionario.TotalDeFuncionarios);

            Console.WriteLine("Salario antes: " + d1.Salario);
            d1.aumentarSalario();
            Console.WriteLine("Salario depois: " + d1.Salario);

            Console.ReadLine();
        }
    }
}
