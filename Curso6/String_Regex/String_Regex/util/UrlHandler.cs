using System;

namespace String_Regex.util {
    /// <summary>
    /// Classe responsável por tratar dados vindos de uma URL
    /// </summary>
    class UrlHandler {

        public string Url { get; }

        /// <summary>
        /// Inicia a variável readonly com o argumento especificado.
        /// </summary>
        /// <exception cref="ArgumentNullException">É Lançado ao informar uma url vazia ou nula.</exception>
        /// <param name="url"></param>
        public UrlHandler(string url) {
            if(String.IsNullOrEmpty(url.Trim())) {
                throw new ArgumentNullException("Argumento \""+nameof(url)+"\" Não pode ser vazio ou nulo.");
            }

            Url = url;
        }
    }
}
