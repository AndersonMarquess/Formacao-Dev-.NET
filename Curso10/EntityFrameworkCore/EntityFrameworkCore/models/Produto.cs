/// <summary>
/// Para sincronizar a classe com a tabela:
///
/// Add-Migration NomeDaMigracao
/// Update-Database
/// 
/// </summary>
namespace EntityFrameworkCore
{
    internal class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double PrecoUnitario { get; set; }
        public string Unidade { get; set; }

        public Produto(string nome, string categoria, double precoUnitario) {
            Nome = nome;
            Categoria = categoria;
            PrecoUnitario = precoUnitario;
        }

        public Produto() {
        }

        //PrecoUnitario:C2 => R$ 9,90
        public override string ToString() {
            return $"Id: {Id} - Categoria: {Categoria} - Nome: {Nome} - Preço: {PrecoUnitario:C2}";
        }
    }
}