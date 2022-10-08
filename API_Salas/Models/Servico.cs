using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models
{
    public class Servico
    { 
        [Required]       
        public int id { get; set; }
         
        [StringLength(100)]
        public string descricao { get; set; }
        public int custo { get; set; }
    }
}
