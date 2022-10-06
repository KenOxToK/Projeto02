using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    public class Sala
    {
        int _id;
        string _identificacao;
        string _descricao;
        int _voltagem;       
        int _numeroMaximoDePessoas;
        int _janelas;
        Endereco _localizacao;
        bool _temBanheiro;
        bool _temEstacionamento;
        bool _temArCondicionado;
        bool _temSeguro;

        public Sala(int id, string identificacao, string descricao, int voltagem, int numeroMaximoDePessoas, int janelas, Endereco localizacao, bool temBanheiro, bool temEstacionamento, bool temArCondicionado, bool temSeguro)
        {
            _id = id;
            _identificacao = identificacao;
            _descricao = descricao;
            _voltagem = voltagem;
            _numeroMaximoDePessoas = numeroMaximoDePessoas;
            _janelas = janelas;
            _localizacao = localizacao;
            _temBanheiro = temBanheiro;
            _temEstacionamento = temEstacionamento;
            _temArCondicionado = temArCondicionado;
            _temSeguro = temSeguro;
        }

        public int Id { get => _id; set => _id = value; }
        public string Identificacao { get => _identificacao; set => _identificacao = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public int Voltagem { get => _voltagem; set => _voltagem = value; }
        public int NumeroMaximoDePessoas { get => _numeroMaximoDePessoas; set => _numeroMaximoDePessoas = value; }
        public int Janelas { get => _janelas; set => _janelas = value; }
        public Endereco Localizacao { get => _localizacao; set => _localizacao = value; }
        public bool TemBanheiro { get => _temBanheiro; set => _temBanheiro = value; }
        public bool TemEstacionamento { get => _temEstacionamento; set => _temEstacionamento = value; }
        public bool TemArCondicionado { get => _temArCondicionado; set => _temArCondicionado = value; }
        public bool TemSeguro { get => _temSeguro; set => _temSeguro = value; }
    }
}
