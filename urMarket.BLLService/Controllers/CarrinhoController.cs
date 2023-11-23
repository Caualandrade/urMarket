using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using urMarket.BLL;
using urMarket.MODEL;

namespace urMarket.BLLService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrinhoController : ControllerBase
    {
        [HttpGet(Name = "ObterCarrinho")]
        public ActionResult<List<Carrinho>> GetCarrinho()
        {
            try
            {
                List<Carrinho> carrinhos = CarrinhoRepository.GetAll();
                if (carrinhos != null)
                {
                    return Ok(carrinhos);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{idUser}",Name = "ObterCarrinhoPorUsuario")]
        public ActionResult<List<Carrinho>> GetCarrinhoUsuario(int idUser)
        {
            try
            {
                List<Carrinho> carrinhos = CarrinhoRepository.GetAllByIdUsuario(idUser);
                if (carrinhos != null)
                {
                    return Ok(carrinhos);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost(Name = "AddCarrinho")]
        public ActionResult<Carrinho> AddCategoria(Carrinho carrinho)
        {
            try
            {
                Carrinho _carrinho = CarrinhoRepository.Add(carrinho);
                return _carrinho == null ? NotFound() : Ok(carrinho);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name ="DeletarCarrinho")]
        public ActionResult DeleteCarrinho(int id)
        {
            try
            {
                var carrinho = CarrinhoRepository.GetById(id);
                CarrinhoRepository.Delete(carrinho);
                return Ok();
            }
            catch (Exception ex) { return StatusCode(500, ex.Message); }
        }

    }
}
