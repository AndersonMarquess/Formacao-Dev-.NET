using System;
using System.Collections.Generic;

namespace ListasLambdaLinq
{
    class TestesExtensoes
    {
        static void Main(string[] args) {

            //Usando extensões genéricas
            List<int> l = new List<int>();
            Teste.adicionarVarios(l, 1, 2, 3, 4);
            int result = l.Find(r => r == 3);
            Console.WriteLine(result);


            //Usando extensão de método genérico
            string and = "Anderson";
            and.Imprimir<string>();// mesmo que Console.WriteLine(and);


            Console.ReadLine();
        }
    }

    public static class Teste {
        //Adiciona vários itens em uma lista de tipo genérico
        public static void adicionarVarios<T>(List<T> lista, params T[] valores) {
            foreach(T item in valores) {
                lista.Add(item);
            }
        }

        //Extensão de método
        public static void Imprimir<T2>(this object obj) {
            Console.WriteLine(obj);
        }
    }
}
