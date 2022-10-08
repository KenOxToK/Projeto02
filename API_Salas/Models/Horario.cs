using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models {
    public class Horario {
        [Key]        
        public int codh { get; set; }

        [Required]
        public DateTime inicio { get; set; }

        [Required]
        public DateTime fim { get; set; }



    }
}
