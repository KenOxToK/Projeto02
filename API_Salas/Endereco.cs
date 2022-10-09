using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    public class Endereco
    {
        //TODO: colocar os métodos da classe como private 
        string _logradouro;
        string _bairro;
        string _numero;
        string _complemento;

        public Endereco(string logradouro, string bairro, string numero, string complemento)
        {
            _logradouro = logradouro;
            _bairro = bairro;
            _numero = numero;
            _complemento = complemento;
        }

        public string Logradouro { get => _logradouro; set => _logradouro = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Complemento { get => _complemento; set => _complemento = value; }
    }
}