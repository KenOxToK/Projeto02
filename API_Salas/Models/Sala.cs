using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models {
    public class Sala {
        [Key]        
        public int cods { get; set; }

        [Required]
        [StringLength(100)]
        public string descricao { get; set; }

        [StringLength(2)]
        public string estado { get; set; }

        [StringLength(100)]
        public string localizacao { get; set; }

        public bool temBanheiro { get; set; }

        public bool temEstacionamento { get; set; }

        public bool temArCondicionado { get; set; }    
    }
}
