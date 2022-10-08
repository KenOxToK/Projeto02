using API_Alunos.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Alunos.Context {
    public class AppDbContext:DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<Equipamento>? Equipamentos { get; set; }
        public DbSet<Sala>? Salas { get; set; }
        public DbSet<Horario>? Horarios { get; set; }
        public DbSet<Periodo>? Periodos { get; set; }
        public DbSet<Endereco>? Enderecos { get; set; }
        // public DbSet<Disponibilidade>? Disponibilidades { get; set; }   
        public DbSet<Servico>? Servicos { get; set; }
    }
}
