using OrientacaoObjetos.Models;
using System;

namespace OrientacaoObjetos.Sistemas
{
    class SistemaInterno {

        public bool Logar(IAutenticavel autenticavel, string senha) {
            bool result = autenticavel.autenticar(senha);

            if(result) {
                Console.WriteLine("Seja bem vindo");
                return true;
            }

            Console.WriteLine("Senha incorreta!");
            return false;
        }
    }
}
