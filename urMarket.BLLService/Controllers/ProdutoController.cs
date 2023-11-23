using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using urMarket.BLL;
using urMarket.MODEL;

namespace urMarket.BLLService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        [HttpGet(Name = "GetProdutos")]
        public ActionResult<List<Produto>> GetProduto()
        {
            try
            {
                List<Produto> produtos = ProdutoRepository.GetAll();
                if (produtos != null)
                {
                    return Ok(produtos);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("{id}",Name = "GetProdutoById")]
        public ActionResult<List<Produto>> GetProdutoById(int id)
        {
            try
            {
                Produto produto = ProdutoRepository.GetById(id);
                if (produto != null)
                {
                    return Ok(produto);
                }
                return NotFound();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }



        [HttpPost(Name = "AddProduto")]
        public ActionResult<Produto> AddProduto(Produto produto)
        {
            try
            {
                Produto _produto = ProdutoRepository.Add(produto);
                return _produto == null ? NotFound() : Ok(produto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete(Name = "DeletarProduto")]
        public ActionResult DeleteProduto(int id)
        {
            try
            {
                var produto = ProdutoRepository.GetById(id);
                ProdutoRepository.Excluir(produto);
                return Ok();
            }
            catch (Exception ex) { return StatusCode(500, ex.Message); }
        }
    }
}
