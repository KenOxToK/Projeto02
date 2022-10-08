using API_Alunos.Context;
using API_Alunos.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Alunos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EquipamentosController : ControllerBase
    {

        private readonly AppDbContext _context;
        public EquipamentosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Equipamento>> Get()
        {
            var equip = _context.Equipamentos.ToList();
            if (equip is null)
            {
                return NotFound();
            }
            return equip;
        }

        [HttpGet("{id:int}", Name = "ObterEqiupamento")]
        public ActionResult<Equipamento> Get(int id)
        {
            var equip = _context.Equipamentos.FirstOrDefault(p => p.code == id);
            if (equip is null)
            {
                return NotFound("equipamento não encontrado...");
            }
            return equip;
        }

        [HttpPost]
        public ActionResult Post(Equipamento equip)
        {
            if (equip is null)
                return BadRequest();

            _context.Equipamentos.Add(equip);
            _context.SaveChanges();

            return new CreatedAtRouteResult("ObterEquipamento",
                new { id = equip.code }, equip);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Equipamento equip)
        {
            if (id != equip.code)
            {
                return BadRequest();
            }

            _context.Entry(equip).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(equip);
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var equip = _context.Equipamentos.FirstOrDefault(p => p.code == id);
            //var aluno = _context.Alunos.Find(id);            

            if (equip is null)
            {
                return NotFound("Aluno não localizado...");
            }
            _context.Equipamentos.Remove(equip);
            _context.SaveChanges();

            return Ok(equip);
        }
    }
}
