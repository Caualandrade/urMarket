using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using urMarket.BLL;
using urMarket.MODEL;

namespace urMarket.BLLService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuario")]
        public ActionResult<List<Usuario>> GetUsuario()
        {
            try
            {
                List<Usuario> usuarios = UsuarioRepository.GetAll();
                if (usuarios != null)
                {
                    return Ok(usuarios);
                }
                return NotFound();
            } catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        
        [HttpGet("user/{idUser}",Name = "GetUsuarioById")]
        public ActionResult<Usuario> GetUsuarioById(int idUser)
        {
            try
            {
                Usuario usuarios = UsuarioRepository.GetById(idUser);
                if (usuarios != null)
                {
                    return Ok(usuarios);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        


        [HttpPost(Name = "AddUsuario")]
        public ActionResult<Usuario> AddUsuario(Usuario usuario)
        {
            try
            {
                Usuario _usuario = UsuarioRepository.Add(usuario);
                return _usuario == null ? NotFound() : Ok(usuario);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpGet("{email}", Name = "VerificarEmail")]
        public ActionResult<Usuario> GetUsuarioEmail(string email)
        {
            try
            {
                Usuario usuario = UsuarioRepository.GetByEmail(email);
                if (usuario != null)
                {
                    return Ok(usuario);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        
    }
}
