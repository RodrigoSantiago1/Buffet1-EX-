using System;
using System.Collections.Generic;
using Buffet1.Models.Evento;
using Buffet1.Models.Tipos;

namespace Buffet1.Models.Cliente
{
    public class ClienteEntity
    {
        private TipoCliente tipo;
        private string Cpf, Cnpj;
        private DateTime datNacs,dataInsercao,ultimoAcesso;
        private string nome, email,endereco,observacoes;
        private List<Convidado.Convidado> Convidados;
        private EventoEntity evento;

        public ClienteEntity()
        {
        }

        public TipoCliente Tipo
        {
            get => tipo;
            set => tipo = value;
        }

        public string Cpf1
        {
            get => Cpf;
            set => Cpf = value;
        }

        public string Cnpj1
        {
            get => Cnpj;
            set => Cnpj = value;
        }

        public DateTime DatNacs
        {
            get => datNacs;
            set => datNacs = value;
        }

        public DateTime DataInsercao
        {
            get => dataInsercao;
            set => dataInsercao = value;
        }

        public DateTime UltimoAcesso
        {
            get => ultimoAcesso;
            set => ultimoAcesso = value;
        }

        public string Nome
        {
            get => nome;
            set => nome = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }

        public string Endereco
        {
            get => endereco;
            set => endereco = value;
        }

        public string Observacoes
        {
            get => observacoes;
            set => observacoes = value;
        }

        public List<Convidado.Convidado> Convidados1
        {
            get => Convidados;
            set => Convidados = value;
        }

        public EventoEntity Evento
        {
            get => evento;
            set => evento = value;
        }
    }
}