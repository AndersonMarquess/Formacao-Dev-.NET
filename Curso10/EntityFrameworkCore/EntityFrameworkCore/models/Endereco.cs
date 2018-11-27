namespace EntityFrameworkCore.models {
    /// <summary>
    /// O Id do endereço é mesmo da tabela principal - Cliente
    /// </summary>
    public class Endereco {
        public string Logradouro { get; internal set; }
        public string Numero { get; internal set; }
        public string Complemento { get; internal set; }
        public string Bairro { get; internal set; }
        public string Cidade { get; internal set; }
        public string CEP { get; internal set; }
        public Cliente Cliente { get; set; }
    }
}