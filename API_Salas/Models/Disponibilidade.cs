using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Alunos.Models
{
    public class Disponibilidade
    {
        [ForeignKey("Salas")]
        public int cods { get; set; }
        [ForeignKey("Periodo")]
        public int codp { get; set; }  
    }
}
