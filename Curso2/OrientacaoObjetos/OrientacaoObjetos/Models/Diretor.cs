namespace OrientacaoObjetos.Models
{
    class Diretor : Funcionario {

        public Diretor(string cpf) : base(cpf, 5000) {
        }

        //Faz o override do virtual no Funcionario
        public override double getBonificacao() {
            return Salario * 0.5;
        }

        public override void aumentarSalario() {
            Salario *= 1.15;
        }
    }
}
