using System;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Cliente
    {
        private int _clienteId;
        private string _nome;
        private string _sobrenome;
        private string _email;
        private DateTime _dataCadastro;
        private bool _ativo;

        public int ClienteId
        {
            get { return _clienteId; }
            set { _clienteId = value; }
        }

                public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        
        public string Sobrenome
        {
            get { return _sobrenome; }
            set { _sobrenome = value; }
        }
        
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        
        public DateTime DataCadastro
        {
            get { return _dataCadastro; }
            set { _dataCadastro = value; }
        }
        
        public bool Ativo
        {
            get { return _ativo; }
            set { _ativo = value; }
        }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}
