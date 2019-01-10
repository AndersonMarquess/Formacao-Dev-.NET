using System;

namespace String_Regex.util {
    /// <summary>
    /// Classe responsável por tratar dados vindos de uma URL
    /// </summary>
    class UrlHandler {

        private readonly string _argumentos;
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

            var index = url.IndexOf("?");
            _argumentos = url.Substring(index++);

            Url = url;
        }

        /// <summary>
        /// Com base no nome do parâmetro, retorna o seu valor.
        /// 
        /// Ex: site.com.br/args?arg1=ola&arg2=mundo
        /// getValor(arg2) -> mundo
        /// 
        /// </summary>
        /// <param name="nomeParametro"></param>
        /// <returns></returns>
        public string getValor(string nomeParametro) {
            string argumentosLowerCase = _argumentos.ToLower();

            var parametroComIgual = nomeParametro+"=";
            var indexInicio = argumentosLowerCase.IndexOf(parametroComIgual.ToLower());

            string resultado = _argumentos.Substring(indexInicio + parametroComIgual.Length);

            var indexFim = resultado.IndexOf('&');

            if(indexFim < 0)
                return resultado;

            return resultado.Remove(indexFim);
        }
    }
}
