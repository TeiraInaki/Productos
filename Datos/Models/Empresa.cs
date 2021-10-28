using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    [Table("Empresa")]
    public class Empresa
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string CUIT { get; set; }

        //Foreign key
        public int id_DatosContacto { get; set; }
        [ForeignKey("id_DatosContacto")]
        public DatosContacto DatosContacto { get; set; }

        

        //Lista de proveedores / Propiedad de navegacion
        public List<Proveedor> Proveedores { get; set; }
    }
}
