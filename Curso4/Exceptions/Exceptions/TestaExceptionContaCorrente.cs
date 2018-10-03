using OrientacaoObjetos;
using System;

namespace Exceptions
{
    class TestaExceptionContaCorrente
    {

        public static void Main(string[] args) {

            try {
                ContaCorrente cc = new ContaCorrente(123, 01);
                cc.sacar(50);
            } catch(Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.ReadLine();
        }
    }
}
