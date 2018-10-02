using OrientacaoObjetos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    class GerenciadorBonificacoes {

        public double totalBonificacoes { get; private set; }

        public GerenciadorBonificacoes registrar(Funcionario funcionario) {
            totalBonificacoes += funcionario.getBonificacao();
            return this;
        }
    }
}
