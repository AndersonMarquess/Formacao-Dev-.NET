namespace EntityFrameworkCore.models {
    public class Cliente {
        public int Id { get; set; }
        public Endereco EnderecoDeEntrega { get; set; }
        public string Nome { get; internal set; }
    }
}
