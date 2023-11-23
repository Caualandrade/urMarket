using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using urMarket.DAL.DBContext;
using urMarket.MODEL;

namespace urMarket.BLL
{
    public class UsuarioRepository
    {
        public static Usuario Add(Usuario usuario)
        {
            using(var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                dbContext.Add(usuario);
                dbContext.SaveChanges();
                return usuario;
            }
        }

        public static List<Usuario> GetAll()
        {
            using (var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.ToList();
                return usuario;
            }
        }

        public static Usuario GetById(int id)
        {
            using (var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p=> p.Id == id);
                return usuario;
            }
        }

        public static Usuario GetByEmail(string email)
        {
            using (var dbContext = new CUsersCaualSourceReposUrmarketUrmarketDalDatabaseDatabaseMdfContext())
            {
                var usuario = dbContext.Usuarios.Single(p => p.Email == email);
                return usuario;
            }
        }

    }
}
