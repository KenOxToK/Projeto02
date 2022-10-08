using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models {
    public class Endereco {
        [Key]        
        public int codend { get; set; }

        [Required]
        [StringLength(100)]
        public string logradouro { get; set; }


    }
}
