using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    public class Servico
    {
        //TODO: colocar os métodos da classe como private e, se necessário o acesso de fora, criar os públicos com get e set
        int _id;
        string _descricao;
        float _custo;

        public Servico(int id, string descricao, float custo)
        {
            _id = id;
            _descricao = descricao;
            _custo = custo;
        }


        //TODO: tirar o get de quem não vai poder ser alterado de fora
        public int Id { get => _id; set => _id = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public float Custo { get => _custo; set => _custo = value; }
    }
}
