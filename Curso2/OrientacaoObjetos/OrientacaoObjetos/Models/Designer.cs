namespace OrientacaoObjetos.Models
{
    class Designer : Funcionario {

        public Designer(string cpf) : base(cpf, 3000) {
        }

        public override double getBonificacao() {
            return Salario * 0.17;
        }

        public override void aumentarSalario() {
            Salario *= 1.11;
        }
    }
}
