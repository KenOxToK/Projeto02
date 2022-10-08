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
    public class Periodo
    {
        private int numero;
       
        public Periodo(int numero)
        {
            this.numero = numero;
        }

        public int Numero { get => numero; set => numero = value; }
       
 
        // Erro por ds ( Dia semana )
        // Talvez eu não lembro deve criar metedo.
        public int Dias (int dsemana) // DS = Dia Semana // dsemana = Dia Semana 
        {
            if (dsemana == 1)
                return (int) DiaSemana.Domingo;
            if (dsemana == 2)
                return (int) DiaSemana.Segunda_Feira;
            if (dsemana == 3)
                return (int) DiaSemana.Terca_Feira;
            if (dsemana == 4)
                return (int) DiaSemana.Quinta_Feira;
            if (dsemana == 5)
                return (int) DiaSemana.Quinta_Feira;
            if (dsemana == 6)
                return (int) DiaSemana.Sexta_Feira;
            if (dsemana == 7)
                return (int) DiaSemana.Sabado;
            else
                return 0;
           
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
