using System;

namespace String_Regex {
    class Program {
        static void Main(string[] args) {
            tratarStringPadrao();

            Console.ReadLine();
        }

        /// <summary>
        /// Pega a string a partir do index 7 e imprime o resultado.
        /// 
        /// Texto padrão = "pagina?argumentos"
        /// Resultado = argumentos
        /// </summary>
        private static void tratarStringPadrao() {
            string url = "pagina?argumentos";
            var index = url.IndexOf("?");
            var resultado = url.Substring(index);
            Console.WriteLine("Resultado da substring: " + resultado);
        }
    }
}
