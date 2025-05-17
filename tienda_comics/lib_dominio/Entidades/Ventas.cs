
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Ventas
    {
        [Key] public int Id { get; set; }
        public string? Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        [ForeignKey("Clientes")] public int ClienteId { get; set; }
        [ForeignKey("Vendedores")] public int VendedorId { get; set; }
        [ForeignKey("Metodos_de_Pagos")] public int Metodo_de_PagoId { get; set; }
        [ForeignKey("Sucursales")] public int SucursalId { get; set; }
        public Clientes? Cliente { get; set; }
        public Vendedores? Vendedor { get; set; }
        public Metodos_de_Pagos? Metodo_de_Pago { get; set; }
        public Sucursales? Sucursal { get; set; }

        public List<Detalles_Ventas>? Detalle_Venta { get; set; }
    }
}
