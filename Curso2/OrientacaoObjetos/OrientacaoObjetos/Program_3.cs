using OrientacaoObjetos.Models;
using OrientacaoObjetos.Sistemas;
using System;

namespace OrientacaoObjetos
{
    class Program_3 {

        static void Main(string[] args) {

            GerenciadorBonificacoes gb = new GerenciadorBonificacoes();

            Designer pedro = new Designer("833.222.048-39") {
                Nome = "Pedro"
            };

            Diretor roberta = new Diretor("159.753.398-04", "123") {
                Nome = "Roberta"
            };

            Auxiliar igor = new Auxiliar("981.198.778-53") {
                Nome = "Igor"
            };

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89", "abc") {
                Nome = "Camila"
            };

            gb.registrar(pedro);
            gb.registrar(roberta);
            gb.registrar(igor);
            gb.registrar(camila);

            Console.WriteLine("Total de bonificações: " + gb.totalBonificacoes);

            autenticar();

            Console.ReadLine();
        }

        static void autenticar() {

            Diretor roberta = new Diretor("159.753.398-04", "123") {
                Nome = "Roberta"
            };

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89", "abc") {
                Nome = "Camila"
            };

            ParceiroComercial parceiro = new ParceiroComercial() {
                Senha = "000"
            };

            SistemaInterno si = new SistemaInterno();
            si.Logar(camila, "abcd");
            si.Logar(camila, "abc");
            si.Logar(parceiro, "000");
        }
    }
}
