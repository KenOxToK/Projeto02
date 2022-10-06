using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    enum DiaSemana
    {
        Domingo = 1,
        Segunda_Feira = 2,
        Terca_Feira = 3,
        Quarta_Feira = 4,
        Quinta_Feira = 5,
        Sexta_Feira = 6,
        Sabado = 7
    }
    class Periodo
    {
        DiaSemana diaSemana;
        Horario _horarios;
        float _preco;
        bool _estaAtiva;
    }
}
