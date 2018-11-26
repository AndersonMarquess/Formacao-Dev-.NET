using EntityFrameworkCore.models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore
{
    public class LojaContext : DbContext
    {
        //Define o tipo e o nome da tabela Produtos
        internal DbSet<Produto> Produtos { get; set; }
        internal DbSet<Compra> Compras { get; set; }
        internal DbSet<Promocao> Promocoes { get; set; }

        //Para criar chave composta
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            //Especifica como é feita a composição da chave primaria da tabela PromocaoProduto
            modelBuilder.Entity<PromocaoProduto>().HasKey(p => new { p.PromocaoId, p.ProdutoId });
            base.OnModelCreating(modelBuilder);
        }

        //Configura o local de acesso ao banco
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
        }
    }
}