using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Professores.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase {

        private readonly AppDbContext _context;
        public ClientesController(AppDbContext context) {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get() {
            var clientes = _context.Professores.ToList();
            if (clientes is null) {
                return NotFound();
            }
            return Ok(clientes);
        }

        [HttpGet("{id:int}", Name = "ObterProfessor")]
        public ActionResult<Cliente> Get(int id) {
            var cliente = _context.clientes.FirstOrDefault(p => p.ClienteId == id);
            if (cliente is null) {
                return NotFound("Professor não encontrado...");
            }
            return cliente;
        }

        [HttpPost]
        public ActionResult Post(Cliente cliente) {
            if (cliente is null)
                return BadRequest();

            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterProfessor",
                new { id = cliente.ClienteId }, cliente);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Cliente cliente) {
            if (id != cliente.ClienteId) {
                return BadRequest();
            }

            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(cliente);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) {
            var cliente = _context.Clientes.FirstOrDefault(p => p.ClienteId == id);
            //var professor = _context.Professores.Find(id);            

            if (cliente is null) {
                return NotFound("Professor não localizado...");
            }
            _context.Clientes.Remove(cliente);
            _context.SaveChanges();

            return Ok(cliente);
        }
    }
}
