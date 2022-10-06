using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    enum DiaSemana
    {
        //TODO: colocar os métodos da classe como private e, se necessário o acesso de fora, criar os públicos com get e set
        Domingo = 1,
        Segunda_Feira = 2,
        Terca_Feira = 3,
        Quarta_Feira = 4,
        Quinta_Feira = 5,
        Sexta_Feira = 6,
        Sabado = 7
    }

    //essa classe ainda vamos ver como fazemos e talvez nem precise dela
    class Periodo
    {
        DiaSemana diaSemana;
        Horario _horarios;
        float _preco;
        bool _estaAtiva;
    }
}
