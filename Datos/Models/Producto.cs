using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Models
{
    [Table("Producto")]

    public class Producto
    {
        public int Id { get; set; }


        [Required]//Not null
        [Column(TypeName = "varchar")]//tipo de dato de SQL Server
        [MaxLength(50)]//hasta 50 
        public string Nombre { get; set; }

        [Required]//Not null
        [Column(TypeName = "varchar")]//tipo de dato de SQL Server
        [MaxLength(50)]//hasta 50
        public string Descripcion { get; set; }

        public decimal PrecioCosto { get; set; }
        public decimal Margen { get; set; }
        public int Id_Proveedor { get; set; }//FK clave externa
        public int Id_Categoria { get; set; }//FK clave externa
        public int Id_SubCategoria { get; set; }//FK clave externa


        //Propiedad de navegación
        [ForeignKey("Id_Proveedor")]
        public Proveedor Proveedor { get; set; }

        [ForeignKey("Id_Categoria")]
        public Categoria Categoria { get; set; }

        [ForeignKey("Id_SubCategoria")]
        public SubCategoria SubCategoria { get; set; }

    }



}

