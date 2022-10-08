using API_Alunos.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Alunos.Context {
    public class AppDbContext:DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Equipamento>? Equipamentos { get; set; }
        public DbSet<Professor>? Professores { get; set; }
    }
}
