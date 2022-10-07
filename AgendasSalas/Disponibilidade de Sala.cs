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
        public Disponibilidade_de_Sala(int id, string identificacao, string descricao, ref List<Periodo> periodos,  Endereco localizacao, int numeroMaximoDePessoas, int voltagem = 110, int janelas = 0, bool temBanheiro = false, bool temEstacionamento = false, bool temArCondicionado = false, bool temSeguro = false )
        {
            _sala = new Sala(id, identificacao, descricao, localizacao, numeroMaximoDePessoas, voltagem, janelas, temBanheiro, temEstacionamento, temArCondicionado, temSeguro);
            _periodo = periodos;
        }


    }
}
