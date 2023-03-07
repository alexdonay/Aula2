using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
   sealed class BancoDados
    {
        private static BancoDados _instance;
        public List<Produto> Produtos= new List<Produto>();

        public void incluir(Produto produto)
        {
            produto.Codigo = Produtos.Count+1;
            Produtos.Add(produto);
        }

        public static BancoDados getInstance()
        {
            if (_instance == null)
            {
                _instance = new BancoDados();
            }
            return _instance;
        }
    }
}
