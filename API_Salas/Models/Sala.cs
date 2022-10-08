using System.ComponentModel.DataAnnotations;

namespace API_Alunos.Models {
    public class Sala {
        [Key]        
        public int cods { get; set; }

        [Required]
        [StringLength(100)]
        public string descricao { get; set; }

        [StringLength(100)]
        public string identificacao { get; set; }

        [StringLength(2)]
        public string estado { get; set; }

        [StringLength(100)]
        public string localizacao { get; set; }

        [StringLength(3)]
        public string temBanheiro { get; set; }

        [StringLength(3)]
        public string temEstacionamento { get; set; }

        [StringLength(3)]
        public string temArCondicionado { get; set; }
        // public int celular { get; set; }

        // public int cpf { get; set; }

        // public int cnpj { get; set; }


    }
}
