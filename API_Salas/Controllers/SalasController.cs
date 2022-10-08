using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Alunos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SalasController : ControllerBase
    {

        private readonly AppDbContext _context;
        public SalasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Sala>> Get()
        {
            var salas = _context.Salas.ToList();
            if (salas is null)
            {
                return NotFound();
            }
            return Ok(salas);
        }

        [HttpGet("{id:int}", Name = "ObterSala")]
        public ActionResult<Sala> Get(int id)
        {
            var sala = _context.Salas.FirstOrDefault(p => p.cods == id);
            if (sala is null)
            {
                return NotFound("Professor não encontrado...");
            }
            return sala;
        }

        [HttpPost]
        public ActionResult Post(Sala sala)
        {
            if (sala is null)
                return BadRequest();

            _context.Salas.Add(sala);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterSala",
                new { id = sala.cods }, sala);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Sala sala)
        {
            if (id != sala.cods)
            {
                return BadRequest();
            }

            _context.Entry(sala).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(sala);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var sala = _context.Salas.FirstOrDefault(p => p.cods == id);           

            if (sala is null)
            {
                return NotFound("Professor não localizado...");
            }
            _context.Salas.Remove(sala);
            _context.SaveChanges();

            return Ok(sala);
        }
    }
}
