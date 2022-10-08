using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Professores.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class ServicosController : ControllerBase {

        private readonly AppDbContext _context;
        public ServicosController(AppDbContext context) {
            _context = context;
        }

        //Obter todas as informações
        [HttpGet]
        public ActionResult<IEnumerable<Servico>> Get() {
            var servicos = _context.Servicos.ToList();
            if (servicos is null) {
                return NotFound();
            }
            return Ok(servicos);
        }

        //obter informação específica peça chave primária
        [HttpGet("{id:int}", Name = "ObterServico")]
        public ActionResult<Servico> Get(int id) {
            var servico = _context.Servicos.FirstOrDefault(p => p.codserv == id);
            if (servico is null) {
                return NotFound("servico não encontrado...");
            }
            return servico;
        }

        //adiciona informação no banco de dados
        [HttpPost]
        public ActionResult Post(Servico servico) {
            if (servico is null)
                return BadRequest();

            _context.Servicos.Add(servico);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterServico",
                new { id = servico.codserv }, servico);
        }

        //edita a informação no banco de dados
        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Servico servico) {
            if (id != servico.codserv) {
                return BadRequest();
            }

            _context.Entry(servico).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(servico);
        }

        //apaga a informação do banco de dados
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) {
            var servico = _context.Servicos.FirstOrDefault(p => p.codserv == id);
            //var professor = _context.Professores.Find(id);            

            if (servico is null) {
                return NotFound("Cliente não localizado...");
            }
            _context.Servicos.Remove(servico);
            _context.SaveChanges();

            return Ok(servico);
        }
    }
}
