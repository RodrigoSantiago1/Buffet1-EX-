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
    }
}