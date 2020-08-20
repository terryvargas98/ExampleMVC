using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleMVC.Models
{
    public class Venta
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public int montoTotal { get; set; }

        public int id_producto { get; set; }

        public int calcularTotal(int cantidad , int precioUnitario)
        {
            int igv= 16;
            
           
            this.montoTotal = cantidad * precioUnitario;
            this.montoTotal = this.montoTotal - (this.montoTotal*igv)/100;
            return montoTotal;
        }
        public void registrarModel(DateTime fecha , int idProducto)
        {
            this.fecha = fecha;
            this.id_producto = idProducto;
        }
      
    }
}
