using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    public class Horario
    {
        //TODO: colocar os métodos da classe como private e, se necessário o acesso de fora, criar os públicos com get e set
        // Feito!
        DateTime _inicio;
        DateTime _fim;

        public DateTime Inicio { get => _inicio; set => _inicio = value; }
        public DateTime Fim { get => _fim; set => _fim = value; }
        

        //TODO: criar construtor
        //Eu tentei criar construtor mais não sei como construtor... fui pesquisar mas ainda diferente. não faço a ideia.
        public Horario()
        {
            DateTime _Inicio = new DateTime(2022, 1, 1, 9, 00, 000);
            Console.WriteLine(_Inicio.Date.ToString());
            Console.WriteLine(_Inicio.TimeOfDay);
            Console.WriteLine(_Inicio.ToLocalTime);

            DateTime _Fim = new DateTime(2022, 12, 31, 24, 00, 000);
            Console.WriteLine(_Fim.Date);
            Console.WriteLine(_Fim.TimeOfDay);
            Console.WriteLine(_Fim.ToLocalTime);
        }
    }
}
