using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.models {
    class Promocao {
        //Sempre criar o atributo de chave primaria
        public int Id { get; set; }
        public string Nome { get; internal set; }
        public DateTime DataInicio { get; internal set; }
        public DateTime DataTermino { get; internal set; }
        public List<PromocaoProduto> Produtos { get; internal set; }

        public Promocao() {
            if(Produtos == null)
                Produtos = new List<PromocaoProduto>();
        }

        internal void AddProdutos(params Produto[] produtos) {
            foreach(var item in produtos) {

                var pp = new PromocaoProduto() {
                    Produto = item
                };

                Produtos.Add(pp);
            }
        }
    }
}
