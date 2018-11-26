using EntityFrameworkCore.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.DAO {
    interface IProdutoDAO {

        void Insert(Produto produto);

        List<Produto> FindAll();

        Produto FindById(int id);

        void Update(Produto produto);

        void Remove(Produto produto);

        void RemoveAll();
    }
}
