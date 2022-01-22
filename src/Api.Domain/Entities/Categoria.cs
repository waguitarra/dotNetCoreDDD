using System;

namespace Api.Domain.Entities
{
    public class Categoria : BaseEntity
    {
        public string tipoCategoria { get; set; }
        public string descricao { get; set; }

    }
}
