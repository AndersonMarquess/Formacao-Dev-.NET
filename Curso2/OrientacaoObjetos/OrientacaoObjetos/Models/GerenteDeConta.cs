namespace OrientacaoObjetos.Models
{
    class GerenteDeConta : Funcionario {

        public GerenteDeConta(string cpf) : base(cpf, 4000) {
        }

        public override double getBonificacao() {
            return Salario * 0.25;
        }

        public override void aumentarSalario() {
            Salario *= 1.05;
        }
    }
}
