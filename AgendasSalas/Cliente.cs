using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    public class Cliente
    {      
        //TODO: colocar os métodos da classe como private 
        private string _nome;
        private string _email;
        private string _celular;

        public Cliente( string nome, string email, string celular)
        {
            _nome = nome;
            _email = email;
            _celular = celular;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }
        public string Celular { get => _celular; set => _celular = value; }
    }
}
