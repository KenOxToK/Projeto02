using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    class Reserva
    {
        List<Disponibilidade_de_Sala> _salasAlugadas;
        List<Equipamento> _equipamentos;
        List<Servico> _servicos;
        List<Objetos> objetos;

        public bool FazerContratacao()
        {
            return true;
        }
    }
}
