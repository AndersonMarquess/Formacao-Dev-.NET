using EntityFrameworkCore.DAO;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace EntityFrameworkCore
{
    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Iniciando execução...");

            using(var contexto = new LojaContext()) {
                ImprimirSQL(contexto);

                //O novo produto criado também será adicionado - Produto e Compra inseridos nas respectivas tabelas.
                RealizarCompra();

                var compra = RealizarCompra();
                contexto.Compras.Add(compra);
                contexto.SaveChanges();

                ImprimirAlteracoes(contexto);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Lista o estado dos itens
        /// </summary>
        /// <param name="contexto"></param>
        private static void ImprimirAlteracoes(LojaContext contexto) {
            Console.WriteLine("=======/Listando Alterações/======");
            foreach(var item in contexto.ChangeTracker.Entries()) {
                Console.WriteLine(item.Entity.ToString() + " => " + item.State);
            }
            Console.WriteLine("=======/Fim da lista/======");
        }

        /// <summary>
        /// Imprime o Código SQL no console
        /// </summary>
        /// <param name="contexto"></param>
        private static void ImprimirSQL(LojaContext contexto) {
            var serviceProvider = contexto.GetInfrastructure();
            var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            loggerFactory.AddProvider(SqlLoggerProvider.Create());
        }

        /// <summary>
        /// Simula uma compra
        /// </summary>
        /// <returns></returns>
        private static Compra RealizarCompra() {
            var produto = new Produto("Produto 1", "Simples", 1.59) {
                Unidade = "Unidade"
            };

            var compra = new Compra();
            compra.Quantidade = 5;
            compra.Produto = produto;
            compra.Preco = compra.Quantidade * produto.PrecoUnitario;

            return compra;
        }
    }
}
