using System;

namespace EntityFrameworkCore
{
    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Gravando arquivo, pressione enter para terminar.");
            GravarComEntity();
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
    }
}
