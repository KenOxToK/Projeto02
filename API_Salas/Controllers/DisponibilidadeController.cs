//using API_Alunos.Context;
//using API_Alunos.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace API_Professores.Controllers
//{
//    [Route("[controller]")]
//    [ApiController]
//    public class DisponibilidadeController : ControllerBase
//    {

//        private readonly AppDbContext _context;
//        public DisponibilidadeController(AppDbContext context)
//        {
//            _context = context;
//        }

//        public AppDbContext Get_context()
//        {
//            return _context;
//        }

//        [HttpGet]
//        public ActionResult<IEnumerable<Disponibilidade>> Get(AppDbContext _context)
//        {
//            var disponibilidades = _context.Disponibilidades.ToList();
//            if (disponibilidades is null)
//            {
//                return NotFound();
//            }
//            return Ok();
//        }

//        [HttpGet("{id:int}", Name = "ObterDisponibilidade")]
//        public ActionResult<Disponibilidade> Get(int id)
//        {          
//            if (disponibilidade is null)
//            {
//                return NotFound("Disponibilidade não encontrado...");
//            }
//            return disponibilidade;
//        }

//        [HttpPost]
//        public ActionResult Post(Disponibilidade disponibilidade)
//        {
//            if (disponibilidade is null)
//                return BadRequest();

//            _context.Disponibilidades.Add(disponibilidade);
//            _context.SaveChanges();

//            return new CreatedAtRouteResult("ObterDisponibilidade",
//                new { id = disponibilidade.codh }, disponibilidade);
//        }

//        [HttpPut("{id:int}")]
//        public ActionResult Put(int id, Disponibilidade disponibilidade)
//        {
//            if (id != disponibilidade.codh)
//            {
//                return BadRequest();
//            }

//            _context.Entry(disponibilidade).State = EntityState.Modified;
//            _context.SaveChanges();

//            return Ok(disponibilidade);
//        }

//        [HttpDelete("{id:int}")]
//        public ActionResult Delete(int id)
//        {
//            var disponibilidade = _context.Disponibilidade.FirstOrDefault(p => p.codh == id);
//            //var professor = _context.Professores.Find(id);            

//            if (disponibilidade is null)
//            {
//                return NotFound("Disponibilidade não localizado...");
//            }
//            _context.Disponibilidades.Remove(disponibilidade);
//            _context.SaveChanges();

//            return Ok(disponibilidade);
//        }
//    }
//}
