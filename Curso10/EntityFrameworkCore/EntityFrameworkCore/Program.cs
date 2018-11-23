using System;
using System.Linq;

namespace EntityFrameworkCore
{
    class Program {

        static void Main(string[] args) {
            GravarComEntity();
            RecuperarProduto();
            ExcluirProdutos();
            RecuperarProduto();

            Console.ReadLine();
        }

        private static void GravarComEntity() {
            Produto p = new Produto("Livro Mock 1", "Livros", 9.90);

            using(var contexto = new LojaContext()) {
                //Adiciona o produto
                contexto.Produtos.Add(p);

                //Salva as alterações
                contexto.SaveChanges();
            }
        }

        private static void RecuperarProduto() {
            using(var contexto = new LojaContext()) {
                //Recupera os produtos salvos e retorna uma lista
                var produtos = contexto.Produtos.ToList();

                Console.WriteLine("Foram encontrados {0} produtos.", produtos.Count);

                //Imprime a lista de produtos
                produtos.ForEach(p => Console.WriteLine(p));
            }
        }

        private static void ExcluirProdutos() {
            using(var contexto = new LojaContext()) {
                //Recupera lista de produtos
                var produtos = contexto.Produtos.ToList();

                //Faz a remoção
                produtos.ForEach(p => contexto.Produtos.Remove(p));

                //Efetiva a alteração
                contexto.SaveChanges();
            }
        }
    }
}
