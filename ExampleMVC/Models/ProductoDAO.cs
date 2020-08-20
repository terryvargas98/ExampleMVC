using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleMVC.Models
{
    public class ProductoDAO
    {
        private readonly ContextBD _context;
        public ProductoDAO(ContextBD context)
        {
            _context = context;
        }
        public List<Producto> ListarProductos()
        {
            List<Producto> ListadoProductos = _context.producto.ToList();

            return ListadoProductos;
        }
        public Producto BuscarProducto(int id)
        {
            Producto ProductoDatos = _context.producto.FirstOrDefault(c => c.id.Equals(id));
            _context.SaveChanges();
            return ProductoDatos;
        }
    }
}
