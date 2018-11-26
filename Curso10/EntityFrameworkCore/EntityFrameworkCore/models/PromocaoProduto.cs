namespace EntityFrameworkCore.models {
    class PromocaoProduto {

        //Chave primaria composta
        public int PromocaoId { get; set; }
        public int ProdutoId { get; set; }
        public Promocao Promocao { get; set; }
        public Produto Produto { get; set; }
    }
}
