using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendasSalas
{
    public class Sala
    {

        //TODO: colocar os métodos da classe como private e, se necessário o acesso de fora, criar os públicos com get e set
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

        //alguna parâmetros podem ter valor padrão pra facilitar a criação e só colocar o que for adicional
        //fiz o exemplo
        public Sala(int id, string identificacao, string descricao, Endereco localizacao, int numeroMaximoDePessoas, int voltagem = 110, int janelas = 0, bool temBanheiro = false, bool temEstacionamento = false, bool temArCondicionado = false, bool temSeguro = false)
        {
            //TODO: gerar id incremental ou aleatório ao invés de receber como parâmetro
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

        //TODO: tirar o get de quem não vai poder ser alterado de fora
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
