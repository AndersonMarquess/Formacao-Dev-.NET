using OrientacaoObjetos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ListasLambdaLinq
{
    class TestesExtensoes
    {
        static void Main(string[] args) {
            //usandoExtensoes();
            //usandoOrdenacao();
            usandoOrderBy();

            Console.ReadLine();
        }

        private static void usandoOrderBy() {
            var clientes = new List<Cliente>();
            clientes.adicionarVarios(
                null,
                new Cliente("Guilherme", profissao: "DC"),
                null,
                new Cliente("Anderson", profissao: "AC"),
                null,
                new Cliente("Marques", profissao: "BM")

            );

            //Linq - Onde o cliente não for nulo, ordene-o pela profissão
            var clientesOrdenadoProfissao = clientes
                .Where(c => c != null)
                .OrderBy(c => c.Profissao);

            foreach(var item in clientesOrdenadoProfissao) {
                Console.WriteLine(item);
            }
        }


        private static void usandoOrdenacao() {
            var idades = new List<int>();
            idades.adicionarVarios(1546, 451, 423, 411, 2, 35, 14, 7891, 012314);
            idades.Sort();
            idades.imprimirLista();


            var nomes = new List<string>();
            nomes.adicionarVarios("anderson", "Anderson", "Marques", "Guilherme", "Matheus");
            nomes.Sort();
            nomes.imprimirLista();


            var clientes = new List<Cliente>();
            clientes.adicionarVarios(
                new Cliente("Anderson", profissao: "AC"),
                new Cliente("Marques", profissao: "DC"),
                new Cliente("Guilherme", profissao: "GM")
            );

            //clientes.Sort(); //Chama a implementação dentro da classe com o IComparable

            clientes.Sort(new ComparadorClientePorCPF());//Chama a implementação da classe externa CompararClientPorCPF

            clientes.imprimirLista();
        }


        private static void usandoExtensoes() {

            //Usando extensões genéricas
            List<int> l = new List<int>();
            Teste.adicionarVarios(l, 1, 2, 3, 4);
            int result = l.Find(r => r == 3);
            Console.WriteLine(result);


            //Usando extensão de método genérico
            string and = "Anderson";
            and.Imprimir<string>();// mesmo que Console.WriteLine(and);
        }
    }

    //Classe com operações de extensão
    public static class Teste
    {
        //Adiciona vários itens em uma lista de tipo genérico
        //Usando o this ele aparece ao apertar . na lista
        public static void adicionarVarios<T>(this List<T> lista, params T[] valores) {
            foreach(T item in valores) {
                lista.Add(item);
            }
        }

        public static void imprimirLista<T>(this List<T> l) {
            foreach(var item in l) {
                Console.WriteLine(item);
            }
        }

        //Extensão de método
        public static void Imprimir<T2>(this object obj) {
            Console.WriteLine(obj);
        }
    }
}
