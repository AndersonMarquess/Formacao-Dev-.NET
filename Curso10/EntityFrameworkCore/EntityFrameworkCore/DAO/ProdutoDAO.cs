using EntityFrameworkCore.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkCore.DAO {
    class ProdutoDAO : IDisposable, IProdutoDAO {

        private LojaContext contexto;

        public ProdutoDAO() {
            contexto = new LojaContext();
        }

        public void Dispose() {
            contexto.SaveChanges();
        }

        public List<Produto> FindAll() {
            return contexto.Produtos.ToList();
        }

        public Produto FindById(int id) {
            return contexto.Produtos.ToList()
                .Where(p => p.Id.Equals(id))
                .First();
        }

        public void Insert(Produto produto) {
            contexto.Produtos.Add(produto);
        }

        public void Remove(Produto produto) {
            contexto.Produtos.ToList().Remove(produto);
        }

        public void RemoveAll() {
            var prods = FindAll();
            foreach(var item in prods) {
                contexto.Remove(item);
            }
        }

        public void Update(Produto produto) {
            contexto.Produtos.Update(produto);
        }
    }
}
