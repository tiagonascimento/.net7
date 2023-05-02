using APICatalogo.Context;
using APICatalogo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace APICatalogo.Controllers
{
   

    [Route("[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase

    {
        private readonly ApiCatalogoAppDbContext _context;
        public CategoriaController(ApiCatalogoAppDbContext context)
        {
            _context = context;
            _context.ChangeTracker.LazyLoadingEnabled = false;
        }
       

        [HttpGet]
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            var categoria = _context.Categorias.AsNoTracking().ToList();
            if (categoria != null)
                return categoria;
            return NotFound();
        }

        [HttpGet("produtos")]
        public ActionResult<IEnumerable<Categoria>> GetCategoriasProdutos()
        {

            

            var categoria = _context.Categorias.AsNoTracking().Include(p => p.Produtos).ToList();

            if (categoria is null)
            {
                return NotFound("Categoria  não encontrado");

            }
            return categoria;
        }
        [HttpGet("{id:int}", Name = "ObterCategoria")]
        public ActionResult<Categoria> Get(int id)
        {
            var categoria = _context.Categorias.AsNoTracking().FirstOrDefault(p => p.CategoriaId == id);
            if (categoria is null)
            {
                return NotFound("Categoria  não encontrado");

            }
            return categoria;
        }
        [HttpPost]
        public ActionResult Post(Categoria categoria)
        {
            if (categoria is null)
                return BadRequest();

            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return new CreatedAtRouteResult("ObterCategoria",
                new { id = categoria.CategoriaId }, categoria);


        }
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Categoria categoria)
        {
            if (categoria is null || id != categoria.CategoriaId)
            {
                return BadRequest();
            }
            _context.Entry(categoria).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok(categoria);
        }
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var categoria = _context.Categorias.FirstOrDefault(p => p.CategoriaId == id);
            if (categoria is null)
            {
                return BadRequest("Produto não Categoria");
            }
            _context.Entry(categoria).State = EntityState.Deleted;
            _context.SaveChanges();
            return Ok(categoria);

        }
    }
}
