using System;
using System.Collections.Generic;
using Buffet1.Models.Cliente;
using Buffet1.Models.Situacao;
using Buffet1.Models.Tipos;

namespace Buffet1.Models.Evento
{
    public class EventoEntity
    {
        private TipoEvento tipo;
        private string descricao;
        private DateTime inicio, terminio;
        private ClienteEntity cliente;
        private SituacaoEvento situacao;
        private Local.Local local;
        private string observacoes;
        private DateTime dataInsercao,ultimaModificacao;
        private List<Convidado.Convidado> Convidados;
    }
}