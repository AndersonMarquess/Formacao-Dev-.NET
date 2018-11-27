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
        internal DbSet<Cliente> Clientes { get; set; }

        //Para criar alterações na criação da tabela, seja chave composta ou herdar um id de outra tabela por exemplo.
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            //Especifica como é feita a composição da chave primaria da tabela PromocaoProduto
            modelBuilder.Entity<PromocaoProduto>().HasKey(p => new { p.PromocaoId, p.ProdutoId });

            //Renome a tabela Endereco para Enderecos
            modelBuilder.Entity<Endereco>().ToTable("Enderecos");

            //Herda o id do Cliente para o Endereço, 
            //Criando uma Shadow property na classe Endereco do tipo int com nome de ClienteId
            modelBuilder.Entity<Endereco>().Property<int>("ClienteId");
            //Define a chave da tabela Enderecos como a propriedade ClienteId
            modelBuilder.Entity<Endereco>().HasKey("ClienteId");

            base.OnModelCreating(modelBuilder);
        }

        //Configura o local de acesso ao banco
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
        }
    }
}