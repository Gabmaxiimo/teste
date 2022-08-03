using System;
using System.Collections.Generic;
using ProEventos.Domain.Enum;
using ProEventos.Domain.Identity;

namespace ProEventos.Domain
{
    public class Evento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime? DataEvento { get; set; }
        public DateTime? DataEventoCriaco { get; set; }
        public DateTime? DataEventoAtualizacao { get; set; }
        public string Tema { get; set; }
        public string status { get; set; }       
        public string ImagemURL { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
       
    }
}