using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using urMarket.DAL.DBContext;
using urMarket.MODEL;

namespace urMarket.BLL
{
    public class CarrinhoRepository
    {
        public static Carrinho Add(Carrinho carrinho)
        {
            using (var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(carrinho);
                dbContext.SaveChanges();
                return carrinho;
            }
        }

        public static List<Carrinho> GetAll()
        {
            using (var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                var carrinho = dbContext.Carrinhos.ToList();
                return carrinho;
            }
        }

        public static List<Carrinho> GetAllByIdUsuario(int id)
        {
            using (var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                Usuario user = UsuarioRepository.GetById(id);
                var carrinho = dbContext.Carrinhos.ToList();
                List<Carrinho> carrinhoUsuario = new List<Carrinho>();
                foreach (var car in carrinho)
                {
                    if(car.IdUsuario == user.Id)
                    {
                        carrinhoUsuario.Add(car);
                    }
                }
                return carrinhoUsuario;
            }
        }

        public static Carrinho GetById(int id)
        {
            using (var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                var carrinho = dbContext.Carrinhos.Single(predicate => predicate.Id == id);
                return carrinho;
            }
        }

        public static void Delete(Carrinho carrinho)
        {
            using (var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                var _carrinho = dbContext.Carrinhos.Single(predicate => predicate.Id == carrinho.Id);
                dbContext.Remove(_carrinho);
                dbContext.SaveChanges();
            }
        }

    }
}
