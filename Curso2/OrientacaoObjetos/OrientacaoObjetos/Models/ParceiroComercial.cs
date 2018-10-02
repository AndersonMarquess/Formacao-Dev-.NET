using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos.Models
{
    class ParceiroComercial : IAutenticavel
    {

        public string Senha { get; set; }

        public bool autenticar(string senha) {
            return senha.Equals(Senha);

        }
    }
}
