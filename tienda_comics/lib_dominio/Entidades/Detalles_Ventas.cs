
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Detalles_Ventas
    {
        [Key] public int Id { get; set; }
        public int Cantidad { get; set; }
        [ForeignKey("Ventas")] public int VentaId { get; set; }
        [ForeignKey("Comics")] public int ComicId { get; set; }
        public Ventas? Venta { get; set; }
        public Comics? Comic { get; set; }

    }
}
