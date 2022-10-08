using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models {
    public class Clientes {
        [Key]        
        public int codc { get; set; }

        [Required]
        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        public int celular { get; set; }

        public int cpf { get; set; }

        public int cnpj { get; set; }


    }
}
