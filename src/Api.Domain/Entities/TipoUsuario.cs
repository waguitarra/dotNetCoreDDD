using System;

namespace Api.Domain.Entities
{
    public class TipoUsuario
    {
        public int tipoUsuarioId { get; set; }
        public string categoria { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFin { get; set; }
    }
}
