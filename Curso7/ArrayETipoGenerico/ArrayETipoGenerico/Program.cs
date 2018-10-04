using ArrayETipoGenerico.Models;
using OrientacaoObjetos;
using System;

namespace ArrayETipoGenerico
{
    class Program
    {
        static void Main(string[] args) {
            //testeArrayDefault();
            testeListaSimples();

            Console.ReadLine();
        }

        private static void testeArrayDefault() {
            Cliente[] clientes = new Cliente[] {
                new Cliente("Cliente 1"),
                new Cliente("Cliente 2"),
                new Cliente("Cliente 3"),
            };


            for(int i = 0; i < clientes.Length; i++) {
                Console.WriteLine(clientes[i]);
            }
        }

        private static void testeListaSimples() {
            Cliente c1 = new Cliente("Cliente 1");
            Cliente c2 = new Cliente("Cliente 2");
            Cliente c3 = new Cliente("Cliente 3");
            Cliente c4 = new Cliente("Cliente 4");

            ListaCaseira<Cliente> clientes = new ListaCaseira<Cliente>();
            clientes.adicionar(c1);
            clientes.adicionar(c2);
            clientes.adicionar(c3);
            clientes.adicionar(c4);

            Console.WriteLine("Cliente no index 2: " + clientes.getClienteNoIndex(1));

            //Teste com indexador
            Console.WriteLine(clientes[3]);

            //Teste de adição com params
            clientes.adicionarVarios(c1, c2, c3, c4);
            Console.WriteLine("Tamanho da lista: " + clientes.tamanho());
        }
    }
}
