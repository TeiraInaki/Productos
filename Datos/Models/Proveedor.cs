using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        


        //Propiedad de Navegacion con producto
        public List<Producto> Productos { get; set; }

        //Relacion con Empresa
        public int id_Empresa { get; set; } //FK
        [ForeignKey("id_Empresa")]
        public Empresa Empresa { get; set; }


    }
}
