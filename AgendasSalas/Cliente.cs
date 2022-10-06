using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    public class Cliente
    {
        int _id;
        string _nome;
        string _email;
        string _celular;

        public Cliente(int id, string nome, string email, string celular)
        {
            _id = id;
            _nome = nome;
            _email = email;
            _celular = celular;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }
        public string Celular { get => _celular; set => _celular = value; }
        public int Id { get => _id; set => _id = value; }
    }
}
