using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using urMarket.BLL;
using urMarket.MODEL;

namespace urMarket.BLLService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpGet(Name ="ObterCategorias")]
        public ActionResult<List<Categoria>> GetCategorias()
        {
            try
            {
                List<Categoria> categorias = CategoriaRepository.GetAll();
                if (categorias != null)
                {
                    return Ok(categorias);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}",Name = "ObterCategoriasById")]
        public ActionResult<Categoria> GetCategoriaById(int id)
        {
            try
            {
                Categoria categoria = CategoriaRepository.GetById(id);
                if (categoria != null)
                {
                    return Ok(categoria);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(Name = "AddCategoria")]
        public ActionResult<Categoria> AddCategoria(Categoria categoria)
        {
            try
            {
                Categoria _categoria = CategoriaRepository.Add(categoria);
                return _categoria == null ? NotFound() : Ok(categoria);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }


        [HttpDelete(Name = "DeletarCategoria")]
        public ActionResult DeleteCategoria(int id)
        {
            try
            {
                var categoria = CategoriaRepository.GetById(id);
                CategoriaRepository.Excluir(categoria);
                return Ok();
            }catch (Exception ex) { return StatusCode(500, ex.Message); }
        }
    }
}
