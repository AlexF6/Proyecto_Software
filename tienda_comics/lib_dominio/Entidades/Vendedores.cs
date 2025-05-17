
using System.ComponentModel.DataAnnotations;

namespace lib_dominio.Entidades
{
    public class Vendedores
    {
        [Key] public int Id { get; set; }
        public string? Carnet { get; set; }
        public string? Nombre { get; set; }
        public List<Ventas>? Ventas { get; set; }
    }
}
