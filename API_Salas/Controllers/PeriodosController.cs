using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Professores.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class PeriodoController : ControllerBase {

        private readonly AppDbContext _context;
        public PeriodoController(AppDbContext context) {
            _context = context;
        }

        public AppDbContext Get_context()
        {
            return _context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Periodo>> Get(AppDbContext _context)
        {
            var periodos = _context.Periodos.ToList();
            if (periodos is null)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpGet("{id:int}", Name = "ObterPeriodo")]
        public ActionResult<Periodo> Get(int id)
        {
            var periodos = _context.Periodos.FirstOrDefault(p => p.codp == id);
            if (periodos is null)
            {
                return NotFound("Periodo não encontrado...");
            }
            return periodos;
        }

        [HttpPost]
        public ActionResult Post(Periodo periodo)
        {
            if (periodo is null)
                return BadRequest();

            _context.Periodos.Add(periodo);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterPeriodo",
                new { id = periodo.codp }, periodo);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Periodo periodo)
        {
            if (id != periodo.codp)
            {
                return BadRequest();
            }

            _context.Entry(periodo).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(periodo);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var periodo = _context.Periodos.FirstOrDefault(p => p.codp == id);
            //var professor = _context.Professores.Find(id);            

            if (periodo is null)
            {
                return NotFound("Periodo não localizado...");
            }
            _context.Periodos.Remove(periodo);
            _context.SaveChanges();

            return Ok(periodo);
        }
    }
}
