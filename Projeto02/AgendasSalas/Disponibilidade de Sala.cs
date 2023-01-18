using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    public class Disponibilidade_de_Sala 
    {
        //TODO: colocar os métodos da classe como private e, se necessário o acesso de fora, criar os públicos com get e set
        private Sala _sala;
        private List<Periodo> _periodo = null;
        public Disponibilidade_de_Sala(Sala sala)
        {
            _sala = sala;
        }      
        public Sala Sala { get => _sala; set => _sala = value; }
        public List<Periodo> Periodo { get => _periodo; set => _periodo = value; }

        //TODO: criar construtor
        public Disponibilidade_de_Sala(ref List<Periodo> periodo)
        {
            _periodo = periodo;
        }
        private Periodo Find(string nomePeriodo)
        {
            Periodo produto = null;
            foreach (Periodo p in _periodo)
            {
            }
            return produto;
        }


    }
}
