using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    class Diretor : Funcionario {

        //Faz o override do virtual no Funcionario
        public override double getBonificacao() {
            return Salario;
        }
    }
}
