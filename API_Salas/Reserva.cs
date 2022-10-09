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

        //Ao invés de lista, a sala será apenas uma, pois a reserva é da sala
        // 1 reserva só pode ter 1 sala e 1 sala, pode ter várias reservas
        Sala _salaAlugada;
        List<Equipamento> _equipamentos;
        List<Servico> _servicos;
        List<Objetos> objetos;

        //TODO: adicionar cliente

        // uma variável booleana para indicar se a reserva está efetuada
        private bool _efetuada = false;

        //TODO: criar construtor recebendo os parametros de sala e período
        //TODO: criar método pra adicionar objetos e serviços
        
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
