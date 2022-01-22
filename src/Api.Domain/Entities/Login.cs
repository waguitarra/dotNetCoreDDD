using System;
using Api.Domain.Entities;

namespace Api.Application
{
    public class Login : BaseEntity
    {
        public string senha { get; set; }
        public string token { get; set; }

        public Guid usuarioId { get; set; }
        public Usuarios Usuaroio { get; set; }

    }
}
