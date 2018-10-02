namespace OrientacaoObjetos.Models
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        //virtual - Permite uma implementação e também que uma classe filha faça override.
        public virtual double getBonificacao() {
            return Salario * 0.10;
        }

    }
}
