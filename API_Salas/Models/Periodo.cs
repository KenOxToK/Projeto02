using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models
{
    public class Periodo
    {
        [Key]
        public int codp { get; set; }

        [Required]   
        public DateTime diaSemana { get; set; }    
        public DateTime time { get; set; }    
        public int preco { get; set; }
        
        [StringLength(20)]
        public string estaAtiva { get; set; }
    }
}
