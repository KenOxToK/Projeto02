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
        //Feito!
        private int _id;
        private string _descricao;
        private float _custo;

        public Servico(int id, string descricao, float custo)
        {
            _id = id;
            _descricao = descricao;
            _custo = custo;
        }


        //TODO: tirar o get de quem não vai poder ser alterado de fora
        // Feito!
        public int Id {  set => _id = value; }
        public string Descricao {  set => _descricao = value; }
        public float Custo {  set => _custo = value; }
    }
}
