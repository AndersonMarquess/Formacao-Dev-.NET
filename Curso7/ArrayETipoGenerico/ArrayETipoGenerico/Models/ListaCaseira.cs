using System;
using OrientacaoObjetos;

namespace ArrayETipoGenerico.Models
{
    class ListaCaseira<T>
    {

        private T[] _objetos;
        private int _index = 0;

        public ListaCaseira(int tamanhoInicial = 10) {
            _objetos = new T[tamanhoInicial];
            _index = 0;
        }

        public void adicionar(T c) {
            verificarCapacidade();

            _objetos[_index++] = c;
            Console.WriteLine($"Item adicionado na posição {_index - 1}");
        }

        public void adicionarVarios(params T[] objetos) {
            foreach(T cliente in objetos)
                adicionar(cliente);
        }

        private void verificarCapacidade() {
            if(_objetos.Length > _index)
                return;

            aumentarCapacidade();
        }

        private void aumentarCapacidade() {
            int novoTamanho = _objetos.Length * 2;
            T[] arrayTemp = new T[novoTamanho];

            //nomeArgumento : valor, nomeArgumento: Valor
            Array.Copy(
                sourceArray: _objetos,
                destinationArray: arrayTemp,
                length: _objetos.Length
            );

            _objetos = arrayTemp;
            Console.WriteLine("Aumentado tamanho da lista");
        }

        public int tamanho() {
            return _index;
        }

        public void remover(T c) {
            int posicaoCliente = -1;
            for(int i = 0; i < _objetos.Length; i++) {
                if(_objetos[i] != null && _objetos[i].Equals(c)) {
                    posicaoCliente = i;
                    break;
                }
            }

            for(int i = posicaoCliente; i < _index; i++) {
                if(_objetos[i + 1] != null)
                    _objetos[i] = _objetos[i + 1];
            }
            _index--;
            Console.WriteLine($"Item na posição {posicaoCliente}, foi removido.");
        }

        public void imprimirConteudo() {
            for(int i = 0; i < _objetos.Length; i++) {
                Console.WriteLine(_objetos[i]);
            }
        }

        public T getClienteNoIndex(int index) {
            if(index < 0 || index >= _index)
                throw new ArgumentOutOfRangeException(nameof(index));

            return _objetos[index];
        }

        //Indexador - cria funcionalidade de index []
        public T this[int index] {
            get {
                return getClienteNoIndex(index);
            }
        }
    }
}
