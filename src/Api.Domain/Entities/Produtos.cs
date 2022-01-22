using System;

namespace Api.Domain.Entities
{
    public class Produtos
    {
        public int tipoUsuarioId { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataFin { get; set; }
        public string descricao { get; set; }
        public string imagem { get; set; }
        public Usuarios usuarios;
        public Categoria categoria { get; set; }
    }
}
