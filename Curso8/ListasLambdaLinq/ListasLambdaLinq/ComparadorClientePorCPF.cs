using OrientacaoObjetos;
using System.Collections;
using System.Collections.Generic;

namespace ListasLambdaLinq {
    class ComparadorClientePorCPF : IComparer<Cliente>
    {
        public int Compare(Cliente x, Cliente y) {

            if(x == y) {
                return 0;
            }
            if(x == null) {
                return -1;
            }
            if(y == null) {
                return 1;
            }

            return x.Cpf.CompareTo(y.Cpf);
        }
    }
}
