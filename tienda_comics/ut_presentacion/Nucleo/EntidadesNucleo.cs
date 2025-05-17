using lib_dominio.Entidades;

namespace ut_presentacion.Nucleo
{
    public class EntidadesNucleo
    {
        public static Categorias? Categorias()
        {
            var entidad = new Categorias
            {
                Nombre = "Manwha",
                Edad_Recomendada = "15+"
            };
            return entidad;
        }

        public static Editoriales? Editoriales()
        {
            var entidad = new Editoriales
            {
                Nombre = "Penguin",
                Distribuidor_Asociado = "Norma"
            };
            return entidad;
        }

        public static Comics? Comics()
        {
            var entidad = new Comics
            {
                Nombre = "Superhéroes",
                Precio = 19900.00m,
                EditorialId= 1,
                CategoriaId= 1

            };
            return entidad;
        }
        
        public static Clientes? Clientes()
        {
            var entidad = new Clientes
            {
                Cedula = "777" + DateTime.Now.ToString("yyyyMMddhhmmssfff"),
                Nombre = "Camilo",
                Email = "Camilo"+ DateTime.Now.ToString("yyyyMMddhhmmssfff") + "@gmail.com"
            }; 
            return entidad;

        }

        public static Vendedores? Vendedores()
        {
            var entidad = new Vendedores
            {
                Carnet = "778" + DateTime.Now.ToString("yyyyMMddhhmmssfff"),
                Nombre = "Julian"
            };
            return entidad;
        }

        public static Sucursales? Sucursales()
        {
            var entidad = new Sucursales
            {
                Nombre = "LA ESTRELLA",
                Direccion = "Calle 23A 108-32"
            };
            return entidad;
        }

        public static Metodos_de_Pagos? Metodos_de_Pagos()
        {
            var entidad = new Metodos_de_Pagos
            {
                Nombre = "Efecty",
                Tipo = "Presencial"
            };
            return entidad;
        }

        public static Ventas? Ventas()
        {
            var entidad = new Ventas
            {
                SucursalId = 1,
                ClienteId = 1,
                VendedorId = 1,
                Fecha = DateTime.Now,
                Codigo = "V-20250401-008",
                Metodo_de_PagoId = 1

            };
            return entidad;
        }

        public static Detalles_Ventas? Detalles_Ventas()
        {
            var entidad = new Detalles_Ventas
            {
                ComicId = 1,
                VentaId = 1,
                Cantidad = 1
            };
            return entidad;
        }
    }
}
