using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using urMarket.DAL.DBContext;
using urMarket.MODEL;

namespace urMarket.BLL
{
    public class ProdutoRepository
    {
        public static Produto Add(Produto produto)
        {
            using (var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                byte[] foto = GetFoto(produto.CaminhoFoto);
                produto.Foto = foto;
                dbContext.Add(produto);
                dbContext.SaveChanges();
                return produto;
            }
        }

        public static List<Produto> GetAll()
        {
            using (var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                var produto = dbContext.Produtos.ToList();
                return produto;
            }
        }

        public static byte[] GetFoto(string caminhoFoto)
        {
            byte[] foto;
            using(var stream = new FileStream(caminhoFoto,FileMode.Open,FileAccess.Read))
            {
                using(var reader = new BinaryReader(stream))
                {
                    foto = reader.ReadBytes((int)stream.Length);
                }
            }
            return foto;
        }

        public static void Excluir(Produto produto)
        {
            using (var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                var _produto = dbContext.Produtos.Single(predicate => predicate.Id == produto.Id);
                dbContext.Remove(_produto);
                dbContext.SaveChanges();

            }
        }

        public static Produto GetById(int id)
        {
            using (var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                
                var produto = dbContext.Produtos.Single(predicate => predicate.Id == id);
                return produto;
            
            }
        }


    }
}
