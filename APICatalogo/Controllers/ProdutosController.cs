using APICatalogo.Context;
using APICatalogo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ApiCatalogoAppDbContext _context;
        public ProdutosController(ApiCatalogoAppDbContext context) {
            _context = context;
            
        }
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos = _context.Produto.ToList();
            if (produtos != null)
                return produtos;
            return NotFound();
        }
        [HttpGet("{id:int}", Name = "ObterProduto")]
        public ActionResult<Produto> Get(int id)
        {
            var produto = _context.Produto.FirstOrDefault(p => p.IdProduto == id);
            if (produto is null) {
                return NotFound("Produto não encontrado");

            }
            return produto;
        }
        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            if (produto is null)
                return BadRequest();

            _context.Produto.Add(produto);
            _context.SaveChanges();
            return new CreatedAtRouteResult("ObterProduto",
                new { id = produto.IdProduto }, produto);


        }
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Produto produto)
        {
            if (produto is null || id != produto.IdProduto)
            {
                return BadRequest();
            }                
            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(produto);
        }
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) 
        {
           var produto = _context.Produto.FirstOrDefault(p => p.IdProduto == id);
            if (produto is null) {
                return BadRequest("Produto não encontrado");
            }
            _context.Entry(produto).State = EntityState.Deleted;
            _context.SaveChanges();
            return Ok(produto);

        }
    }
}
