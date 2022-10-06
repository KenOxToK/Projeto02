using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    public class Servico
    {
        int _id;
        string _descricao;
        float _custo;

        public Servico(int id, string descricao, float custo)
        {
            _id = id;
            _descricao = descricao;
            _custo = custo;
        }

        public int Id { get => _id; set => _id = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public float Custo { get => _custo; set => _custo = value; }
    }
}
