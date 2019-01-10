using String_Regex.util;
using System;

namespace String_Regex {
    class Program {
        static void Main(string[] args) {
            //tratarStringPadrao();

            var url = @"http://www.site.com/pagina?
                            arg1=hello
                           &arg2=world
                           &arg3=code";

            UrlHandler urlHandler = new UrlHandler(url);
            Console.WriteLine(urlHandler.getValor("aRG2"));

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
