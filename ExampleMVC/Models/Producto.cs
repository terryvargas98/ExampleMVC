using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ExampleMVC.Models
{
    public class Producto
    {

         
        [Key]
        public int id { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public int precioUnitario { get; set; }
        [Required]
        public int cantidad { get; set; }
    }
}


