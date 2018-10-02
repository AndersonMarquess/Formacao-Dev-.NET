using System;

namespace OrientacaoObjetos.Models
{
    abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario) {
            TotalDeFuncionarios++;
            CPF = cpf;
            Salario = salario;
        }

        //virtual - Permite uma implementação e também que uma classe filha faça override.
        //abstract - Obriga fazer o override
        public abstract double getBonificacao();

        public abstract void aumentarSalario();
    }
}
