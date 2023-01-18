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
        private int _idade;
        private int _id;

        public Cliente( string nome, string email, string celular, int idade, int id)
        {
            _nome = nome;
            _email = email;
            _celular = celular;
            _idade = idade;
            _id = id;          
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }
        public string Celular { get => _celular; set => _celular = value; }
        public int Id { get => _id; set => _id = value; }
        public int Idade { get => _idade; set => _idade = value; }
    }
}
