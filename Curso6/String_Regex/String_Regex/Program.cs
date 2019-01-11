using String_Regex.util;
using System;
using System.Text.RegularExpressions;

namespace String_Regex {
    class Program {
        static void Main(string[] args) {
            //tratarStringPadrao();
            //extrairValorUrlPadrao();
            usandoRegex();


            Console.ReadLine();
        }

        private static void usandoRegex() {
            string dado = "Meu número de telefone é: 11-91234-5698";
            string padraoTelefone = "[0-9]{2}-[0-9]{5}-[0-9]{4}";
            Console.WriteLine("O Padrão existe: "+Regex.IsMatch(dado, padraoTelefone));
            Console.WriteLine("Padrão recuperado: "+Regex.Match(dado, padraoTelefone));
        }

        /// <summary>
        /// Com base no nome do parâmetro, recupera o valor presente na url.
        /// </summary>
        private static void extrairValorUrlPadrao() {
            var url = @"http://www.site.com/pagina?
                            arg1=hEllo
                           &arg2=WorlD
                           &arg3=coDE";

            UrlHandler urlHandler = new UrlHandler(url);
            Console.WriteLine(urlHandler.getValor("ArG3"));
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
