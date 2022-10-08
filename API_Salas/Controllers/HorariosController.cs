using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Professores.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class HorariosController : ControllerBase {

        private readonly AppDbContext _context;
        public HorariosController(AppDbContext context) {
            _context = context;
        }

        public AppDbContext Get_context()
        {
            return _context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Horario>> Get(AppDbContext _context)
        {
            var horarios = _context.Horarios.ToList();
            if (horarios is null)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpGet("{id:int}", Name = "ObterHorario")]
        public ActionResult<Horario> Get(int id)
        {
            var horarios = _context.Horarios.FirstOrDefault(p => p.codh == id);
            if (horarios is null)
            {
                return NotFound("Horario não encontrado...");
            }
            return horarios;
        }

        [HttpPost]
        public ActionResult Post(Horario horario) {
            if (horario is null)
                return BadRequest();

            _context.Horarios.Add(horario);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterHorario",
                new { id = horario.codh }, horario);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Horario horario)
        {
            if (id != horario.codh)
            {
                return BadRequest();
            }

            _context.Entry(horario).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(horario);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var horario = _context.Horarios.FirstOrDefault(p => p.codh == id);
            //var professor = _context.Professores.Find(id);            

            if (horario is null)
            {
                return NotFound("Horario não localizado...");
            }
            _context.Horarios.Remove(horario);
            _context.SaveChanges();

            return Ok(horario);
        }
    }
}
