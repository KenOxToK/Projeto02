using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models {
    public class Cliente {
        [Key]        
        public int codc { get; set; }

        [Required]
        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        public decimal celular { get; set; }

        public decimal cpf { get; set; }

        public decimal cnpj { get; set; }


    }
}
