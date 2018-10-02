namespace OrientacaoObjetos.Models
{
    class Diretor : FuncionarioAutenticavel {


        public Diretor(string cpf, string senha)
            : base(cpf, 5000, senha) {
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
