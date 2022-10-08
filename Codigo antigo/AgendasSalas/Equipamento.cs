using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    //mesma coisa que falei na de objetos
    public class Equipamento
    {
        private string _nome;
        private string _descricao;
        private int _voltagem; //110 ou 220
        private float _peso;
        private string _volume;
        private float _custoTotal;
        private float _custoSeguro;
        private float _custoHora;

        public Equipamento(string nome, string descricao, int voltagem, float peso, string volume, float custoTotal, float custoSeguro, float custoHora)
        {
            _nome = nome;
            _descricao = descricao;
            _voltagem = voltagem;
            _peso = peso;
            _volume = volume;
            _custoTotal = custoTotal;
            _custoSeguro = custoSeguro;
            _custoHora = custoHora;
        }
        //Tirei o get aqui tambem!
        //Feito!
        public string Nome { set => _nome = value; }
        public string Descricao {  set => _descricao = value; }
        public int Voltagem {  set => _voltagem = value; }
        public float Peso {  set => _peso = value; }
        public string Volume { set => _volume = value; }
        public float CustoTotal {  set => _custoTotal = value; }
        public float CustoSeguro {  set => _custoSeguro = value; }
        public float CustoHora {  set => _custoHora = value; }
    }
}
