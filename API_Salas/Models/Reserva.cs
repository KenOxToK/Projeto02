using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API_Alunos.Models {
    public class Reserva {

        public Reserva() {
            Servico = new Collection<Servico>();
        }

        
        [Key]        
        public int codr { get; set; }

        public int codd { get; set; }

        [Required]
        public int cods { get; set; }

        public int code { get; set; }

        public int codserv { get; set; }

        public decimal valorTotal { get; set; }

        public bool reservaEfetuada { get; set; }

        public ICollection<Servico>? Servico { get; set; }

    }
}
