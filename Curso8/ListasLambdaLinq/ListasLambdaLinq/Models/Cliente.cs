using System;
using System.Collections.Generic;

namespace OrientacaoObjetos
{
    public class Cliente : IComparable {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public Cliente(string nome, string cpf = "000.000.000-10", string profissao = "Profissâo default") {
            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;
        }

        public override string ToString() {
            return $"Nome: {Nome}, CPF: {Cpf}, Profissão: {Profissao}.";
        }

        public override bool Equals(object obj) {
            var cliente = obj as Cliente;
            return cliente != null &&
                   Nome == cliente.Nome &&
                   Cpf == cliente.Cpf &&
                   Profissao == cliente.Profissao;
        }

        public override int GetHashCode() {
            var hashCode = 520494327;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Cpf);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Profissao);
            return hashCode;
        }

        public int CompareTo(object obj) {
            var objc = obj as Cliente;

            if(objc == null)
                return -1;

            return this.Nome.CompareTo(objc.Nome) - (this.Profissao.CompareTo(objc.Profissao));
        }
    }
}