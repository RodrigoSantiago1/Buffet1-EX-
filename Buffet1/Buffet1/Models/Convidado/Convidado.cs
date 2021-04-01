using System;
using Buffet1.Models.Cliente;
using Buffet1.Models.Evento;
using Buffet1.Models.Situacao;

namespace Buffet1.Models.Convidado
{
    public class Convidado
    {
        private string nome, email;
        private int cpf;
        private EventoEntity evento;
        private ClienteEntity cliente;
        private SituacaoConvidado situacao;
        private DateTime datNacs,dataInsercao,ultimaModificacao;
    }
}