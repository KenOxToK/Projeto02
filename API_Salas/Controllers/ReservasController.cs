using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Professores.Controllers
{  
    [Route("[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase {


        private readonly AppDbContext _context;
        public ReservasController(AppDbContext context) {
            _context = context;
        }

        //TODO: trocar os nomes das variaveis de cliente pra reserva
        [HttpGet]     
        public ActionResult<IEnumerable<Cliente>> Get() {
            var reservas = _context.Reservas.ToList();
            if (reservas is null) {
                return NotFound();
            }
            return Ok(reservas);
        }

        //TODO: trocar os nomes das variaveis de cliente pra reserva
        [HttpGet("{id:int}", Name = "ObterReserva")]      
        public ActionResult<Reserva>Get(int id) {
            var reserva = _context.Reservas.FirstOrDefault(p => p.codr == id);
            if (reserva is null) {
                return NotFound("cliente não encontrado...");
            }
            return reserva;
        }

        [HttpPost]     
        public ActionResult Post(Reserva reserva) {
            if (reserva is null)
                return BadRequest();

            _context.Reservas.Add(reserva);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterReserva",
                new { id = reserva.codr }, reserva);
        }
        [HttpPut("{id:int}")]       
        public ActionResult Put(int id, Cliente reserva) {
            if (id != reserva.codc) {
                return BadRequest();
            }

            _context.Entry(reserva).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(reserva);
        }
        [HttpDelete("{id:int}")]    
        public ActionResult Delete(int id) {
            var reserva = _context.Reservas.FirstOrDefault(p => p.codr == id);
            //var professor = _context.Professores.Find(id);            

            if (reserva is null) {
                return NotFound("Cliente não localizado...");
            }
            _context.Reservas.Remove(reserva);
            _context.SaveChanges();

            return Ok(reserva);
        }
    }
}
