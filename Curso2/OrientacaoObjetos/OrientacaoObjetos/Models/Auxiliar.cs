namespace OrientacaoObjetos.Models
{
    class Auxiliar : Funcionario {

        public Auxiliar(string cpf) : base(cpf, 2000) {
        }

        public override double getBonificacao() {
            return Salario * 0.20;
        }

        public override void aumentarSalario() {
            Salario *= 1.10;
        }
    }
}
