using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore
{
    public class LojaContext : DbContext
    {
        //Define o tipo e o nome da tabela Produtos
        internal DbSet<Produto> Produtos { get; set; }
        internal DbSet<Compra> Compras { get; set; }

        //Configura o local de acesso ao banco
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
        }
    }
}