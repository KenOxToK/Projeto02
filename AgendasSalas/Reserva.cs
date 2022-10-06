using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    class Reserva
    {
        //TODO: colocar os métodos da classe como private e, se necessário o acesso de fora, criar os públicos com get e set
        //Feito!

        //Ao invés de lista, a sala será apenas uma, pois a reserva é da sala
        // 1 reserva só pode ter 1 sala e 1 sala, pode ter várias reservas
        private Cliente _cliente;
        private Sala _salaAlugada;
        private List<Equipamento> _equipamentos;
        private List<Servico> _servicos;
        private List<Objetos> _objetos = null;

        public Reserva(Sala salaAlugada, List<Equipamento> equipamentos, List<Servico> servicos, List<Objetos> objetos, Cliente cliente)
        {
            _cliente = cliente;
            _salaAlugada = salaAlugada;
            _equipamentos = equipamentos;
            _servicos = servicos;
            this._objetos = objetos;
            
        }

        //TODO: adicionar cliente
        public Reserva (string nome,string email,string celular)
        {
            _cliente = new Cliente("", "", "");
        }

        // uma variável booleana para indicar se a reserva está efetuada
        private bool _efetuada = false;

        //TODO: criar construtor recebendo os parametros de sala e período

        //TODO: criar método pra adicionar objetos e serviços             
        public Reserva(string nome, string _descricao)
        {
            _objetos = new Objetos("","","");

        }

        public bool FazerContratacao()
        {
            //TODO: verificar se o período está disponível para a sala escolhida,

            //verificar equipamentos e objetos estão disponíveis,

            // colocar o cliente e true no efetuado,

            // tirar a vaga da disponibilidade de salas

            return true;
        }
    }
}
