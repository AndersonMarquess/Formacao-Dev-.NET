namespace OrientacaoObjetos.Models
{
    class GerenteDeConta : FuncionarioAutenticavel {

        public GerenteDeConta(string cpf, string senha)
            : base(cpf, 3000, senha) {
        }

        public override double getBonificacao() {
            return Salario * 0.25;
        }

        public override void aumentarSalario() {
            Salario *= 1.05;
        }
    }
}
