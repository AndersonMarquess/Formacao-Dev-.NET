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
                contexto.Produtos.ToList().ForEach(p => Console.WriteLine(p));
                ImprimirAlteracoes(contexto);
            }
            Console.ReadLine();
        }

        private static void ImprimirAlteracoes(LojaContext contexto) {
            Console.WriteLine("=======/Listando Alterações/======");
            foreach(var item in contexto.ChangeTracker.Entries()) {
                Console.WriteLine(item.Entity.ToString() + " => " + item.State);
            }
            Console.WriteLine("=======/Fim da lista/======");
        }

        private static void ImprimirSQL(LojaContext contexto) {
            var serviceProvider = contexto.GetInfrastructure();
            var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
            loggerFactory.AddProvider(SqlLoggerProvider.Create());
        }
    }
}
