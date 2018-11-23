namespace EntityFrameworkCore
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }

        public Produto(string nome, string categoria, double preco) {
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
        }

        public Produto() {
        }

        public override string ToString() {
            return $"Id: {Id} - Categoria: {Categoria} - Nome: {Nome} - Preço: R${Preco}";
        }
    }
}