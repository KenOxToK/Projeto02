using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    public class Objetos
    {
        //TODO: colocar os métodos da classe como private 
        //Feito
        private int _id;
        private string _nome;
        private string _descricao;

        public Objetos(int id, string nome, string descricao)
        {
            _id = id;
            _nome = nome;
            _descricao = descricao;
        }
        
        public int Id {  get => _id; set => _id = value; }
        public string Nome {  get => _nome; set => _nome = value; }
        public string Descricao {  get => _descricao; set => _descricao = value; }
    }
}
