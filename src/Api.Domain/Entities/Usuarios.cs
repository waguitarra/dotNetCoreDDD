using System;
using Api.Application;

namespace Api.Domain.Entities
{
    public class Usuarios : BaseEntity
    {

        public string nome { get; set; }
        public string email { get; set; }
        public string cep { get; set; }
        public string sexo { get; set; }
        public int tipoUsuarioId { get; set; }
        public TipoUsuario tipoUsuario { get; set; }

        public Guid loginId { get; set; }
        public Login login { get; set; }



    }
}
