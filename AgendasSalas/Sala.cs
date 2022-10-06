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
        // Feito!
        private int _id;
        private string _identificacao;
        private string _descricao;
        private int _voltagem;       
        private int _numeroMaximoDePessoas;
        private int _janelas;
        private Endereco _localizacao;
        private bool _temBanheiro;
        private bool _temEstacionamento;
        private bool _temArCondicionado;
        private bool _temSeguro;

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
        // Feito!
        public int Id { set => _id = value; }
        public string Identificacao {  set => _identificacao = value; }
        public string Descricao {  set => _descricao = value; }
        public int Voltagem {  set => _voltagem = value; }
        public int NumeroMaximoDePessoas {  set => _numeroMaximoDePessoas = value; }
        public int Janelas {  set => _janelas = value; }
        public Endereco Localizacao {  set => _localizacao = value; }
        public bool TemBanheiro {  set => _temBanheiro = value; }
        public bool TemEstacionamento {  set => _temEstacionamento = value; }
        public bool TemArCondicionado {  set => _temArCondicionado = value; }
        public bool TemSeguro {  set => _temSeguro = value; }
    }
}
