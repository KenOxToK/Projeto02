using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models
{
    public class Servico
    { 
        [Key]       
        public decimal codserv { get; set; }
         
        [StringLength(100)]
        public string descricao { get; set; }

        public decimal custo { get; set; }
    }
}
