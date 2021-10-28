using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos.Models;

namespace Datos.Data
{
    public class DbProductosContext : DbContext
    {
        public DbProductosContext() : base("KeyDBProductos") { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<DatosContacto> DatosContacto { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<SubCategoria> SubCategorias { get; set; }
    }
}
