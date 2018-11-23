using System;
using System.Linq;

namespace EntityFrameworkCore
{
    class Program {

        static void Main(string[] args) {
            //GravarComEntity();
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
            using(var rep = new LojaContext()) {
                //Recupera os produtos salvos e retorna uma lista
                var produtos = rep.Produtos.ToList();
                //Imprime a lista de produtos
                produtos.ForEach(p => Console.WriteLine(p));
            }
        }
    }
}
