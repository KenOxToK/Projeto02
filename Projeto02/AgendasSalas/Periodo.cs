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
    public class Periodo : Horario
    {
        private int numero;
        // Coloquei this por isso ter usar list
        public Periodo(int numero)
        {
            this.numero = numero;
        }

        public int Numero { get => numero; set => numero = value; }
       
        // Não sei porquê 
        // Erro por dm ( Dia semana )
        // Talvez eu não lembro deve criar metedo.
        public DiaSemana dm (int semana)
        {
            if (semana == 1)
                return DiaSemana.Domingo;
            if (semana == 2)
                return DiaSemana.Segunda_Feira;
            if (semana == 3)
                return DiaSemana.Terca_Feira;
            if (semana == 4)
                return DiaSemana.Quinta_Feira;
            if (semana == 5)
                return DiaSemana.Quinta_Feira;
            if (semana == 6)
                return DiaSemana.Sexta_Feira;
            if (semana == 7)
                return DiaSemana.Sabado;
            else
                return.0;
        }
    }



    //essa classe ainda vamos ver como fazemos e talvez nem precise dela
    //class Periodo
    //{
    //    DiaSemana diaSemana;
    //    Horario _horarios;
    //    float _preco;
    //    bool _estaAtiva;
    //}
}
