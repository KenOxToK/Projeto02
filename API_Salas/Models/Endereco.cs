using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models
{
    public class Endereco
    {
        [Key]
        public int codend { get; set; }

        [Required]
        [StringLength(60)]
        public string logradouro { get; set; }

        [StringLength(30)]
        public string bairro { get; set; }

        public int numero { get; set; }
      
        [StringLength(3)]
        public string complemento { get; set; }

    }
}
