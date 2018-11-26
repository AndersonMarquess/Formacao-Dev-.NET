﻿using EntityFrameworkCore.models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace EntityFrameworkCore
{
    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Iniciando execução...");

            using(var contexto = new LojaContext()) {
                ImprimirSQL(contexto);

                //var promo = RealizarPromocao();
                //contexto.Promocoes.Add(promo);
                //var p = contexto.Promocoes.Find(1);
                //contexto.Promocoes.Remove(p);

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

        /// <summary>
        /// Simula uma promoção com relacionamento N:N para com produto
        /// </summary>
        /// <returns></returns>
        private static Promocao RealizarPromocao() {
            var promo = new Promocao {
                Nome = "Nome da super promoção",
                DataInicio = DateTime.Today,
                DataTermino = DateTime.Today.AddMonths(3)
            };

            var p1 = new Produto("RPG", "Jogo", 37.90) { Unidade = "Unidade" };
            var p2 = new Produto("Bola", "Esporte", 19.90) { Unidade = "Unidade" };

            promo.AddProdutos(p1, p2);

            return promo;
        }
    }
}
