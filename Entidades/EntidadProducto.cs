using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class EntidadProducto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Nombre { get; set; }
        [StringLength(100, MinimumLength = 1)]
        public string Descripcion { get; set; }
        [Range(1,100 , ErrorMessage = "Introduccion un valor entre 1 y 100")]
        public Nullable<int> RestriccionEdad { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string Compañia { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Introduccion un valor entre 1 y 100")]
        public Nullable<decimal> Precio { get; set; }
    }
}
