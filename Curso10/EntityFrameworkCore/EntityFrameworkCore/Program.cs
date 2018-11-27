using EntityFrameworkCore.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace EntityFrameworkCore {
    class Program {

        static void Main(string[] args) {
            Console.WriteLine("Iniciando execução...");

            using(var contexto = new LojaContext()) {
                ImprimirSQL(contexto);

                SelectComJoin(contexto);

                ImprimirAlteracoes(contexto);
            }
            Console.ReadLine();
        }

        private static void SelectComJoin(LojaContext contexto) {
            //Select do cliente com left join na tabela enderecos
            var cliente = contexto.Clientes
                .Include(e => e.EnderecoDeEntrega)
                .FirstOrDefault();
            Console.WriteLine(cliente.EnderecoDeEntrega.Logradouro);

            //Join do produto com compras =>
            //traga a quantidade comprada do item especificado onde o id do produto for igual a 2002
            var produto = contexto.Produtos
                .Include(p => p.Compras)
                .Where(p => p.Id == 2002)
                .FirstOrDefault();

            //Extensão para adição de where, filtra e adiciona o resultado na referência
            contexto.Entry(produto)
                .Collection(p => p.Compras)
                .Query()
                .Where(c => c.Preco > 10)
                .Load();

            Console.WriteLine("Exibindo compras do produto: " + produto.Nome);
            foreach(var item in produto.Compras) {
                Console.WriteLine(item.Preco);
            }
        }

        /// <summary>
        /// Faz um select no banco trazendo dados da tabela Promocoes e Produtos usando o JOIN(Include)
        /// </summary>
        /// <param name="contexto"></param>
        private static void RealizarBuscaComJOIN(LojaContext contexto) {
            //select * from PROMOCOES as P 
            //inner join PROMOCAOPRODUTOS as PP on PP.PROMOCAOID = P.ID
            //inner join PRODUTOS as PD on PD.ID = PP.PRODUTOID
            var promocao = contexto.Promocoes
                .Include(p => p.Produtos)
                .ThenInclude(pp => pp.Produto)
                .FirstOrDefault();

            Console.WriteLine("Produtos da promoção");
            promocao.Produtos.ForEach(p => Console.WriteLine(p.Produto));
        }

        /// <summary>
        /// Realiza um select com where e uso o resultado para criar uma promoção
        /// </summary>
        /// <param name="contexto"></param>
        /// <returns></returns>
        private static Promocao InserirPromocaoComCondicao(LojaContext contexto) {
            var promocao = new Promocao() {
                Nome = "Promoção e pra mocinha",
                DataInicio = DateTime.Today,
                DataTermino = DateTime.Today.AddMonths(1)
            };

            //Select * From PRODUTOS as P where P.Categoria = "Jogo"
            var produtos = contexto.Produtos.Where(p => p.Categoria == "Jogo").ToList();

            foreach(var item in produtos) {
                promocao.AddProdutos(item);
            }

            return promocao;
        }

        /// <summary>
        /// Endereço do cliente também é mapeado e persistido pelo entity, por que ela está relacionada ao Cliente.
        /// Relacionamento do tipo 1:1
        /// </summary>
        private static Cliente GerarClientePadrao() {
            var cliente = new Cliente {
                Nome = "Cliente 01"
            };

            var endereco = new Endereco() {
                Logradouro = "Av. Padrão",
                Numero = "510B",
                Complemento = "",
                Bairro = "Centro",
                Cidade = "Cidade padrão",
                CEP = "12345-542"
            };

            cliente.EnderecoDeEntrega = endereco;
            return cliente;
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
        /// Simula uma compra, por se tratar de um novo produto, o mesmo será inserido ao banco junto com a compra.
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
