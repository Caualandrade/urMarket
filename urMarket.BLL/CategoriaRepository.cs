using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using urMarket.DAL.DBContext;
using urMarket.MODEL;

namespace urMarket.BLL
{
    public class CategoriaRepository
    {
        public static Categoria Add(Categoria categoria)
        {
            using(var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(categoria);
                dbContext.SaveChanges();
                return categoria;
            }
        }

        public static List<Categoria> GetAll()
        {
            using (var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                var categoria = dbContext.Categorias.ToList();
                return categoria;
            }
        }
        public static Categoria GetById(int id)
        {
            using (var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                var categoria = dbContext.Categorias.Single(predicate => predicate.Id == id);
                return categoria;
            }
        }


        public static void Excluir(Categoria categoria)
        {
            using (var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                var _categoria = dbContext.Categorias.Single(predicate => predicate.Id == categoria.Id);
                dbContext.Remove(_categoria);
                dbContext.SaveChanges();
                
            }
        }
    }
}
