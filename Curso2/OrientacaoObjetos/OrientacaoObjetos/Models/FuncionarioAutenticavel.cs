namespace OrientacaoObjetos.Models
{
    //Classe : Extends, Implements
    abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; }

        public FuncionarioAutenticavel(string cpf, double salario, string senha) : base(cpf, salario) {
            Senha = senha;
        }

        public bool autenticar(string senha) {
            return senha.Equals(Senha);
        }
    }
}
