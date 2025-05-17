


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_dominio.Entidades
{
    public class Comics
    {
        [Key] public int Id { get; set; }
        public string? Nombre { get; set; }
        public Decimal Precio { get; set; }
        [ForeignKey("Editoriales")] public int EditorialId { get; set;}
        [ForeignKey("Categorias")] public int CategoriaId { get; set;}
        public Editoriales? Editorial { get; set; }
        public Categorias? Categoria { get; set; }

        public List<Detalles_Ventas>? Detalle_Venta { get; set; }
    }
}
