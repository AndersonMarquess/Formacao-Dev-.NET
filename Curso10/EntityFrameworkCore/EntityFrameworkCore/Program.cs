using EntityFrameworkCore.DAO;
using System;
using System.Linq;

namespace EntityFrameworkCore
{
    class Program {

        static void Main(string[] args) {
            //GravarComEntity();
            //RecuperarProduto();
            //ExcluirProdutos();
            RecuperarProduto();
            AtualizarProduto();
            RecuperarProduto();

            Console.ReadLine();
        }

        private static void GravarComEntity() {
            Produto p = new Produto("Livro Mock 1", "Livros", 9.90);

            using(var contexto = new ProdutoDAO()) {
                //Adiciona o produto
                contexto.Insert(p);
            }
        }

        private static void RecuperarProduto() {
            using(var contexto = new ProdutoDAO()) {
                //Recupera os produtos salvos e retorna uma lista
                var produtos = contexto.FindAll();

                Console.WriteLine("Foram encontrados {0} produtos.", produtos.Count);

                //Imprime a lista de produtos
                produtos.ForEach(p => Console.WriteLine(p));
            }
        }

        private static void ExcluirProdutos() {
            using(var contexto = new ProdutoDAO()) {
                //Recupera lista de produtos
                var produtos = contexto.FindAll();

                //Faz a remoção
                produtos.ForEach(p => contexto.Remove(p));
            }
        }

        private static void AtualizarProduto() {
            using(var contexto = new ProdutoDAO()) {
                Produto produto = contexto.FindAll().First();
                produto.Nome = "Livro atualizado";
                contexto.Update(produto);
            }
        }
    }
}
