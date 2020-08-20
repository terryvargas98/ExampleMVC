using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleMVC.Models
{
    public class VentaDAO
    {
        private readonly ContextBD _context;
        public VentaDAO(ContextBD context)
        {
            _context = context;
        }
        public void RegistrarVentaRepository(Venta MiVenta)
        {

            _context.venta.Add(MiVenta);
            _context.SaveChanges();


        }
        public Venta BuscarVenta(int id)
        {
            Venta VentaDatos = _context.venta.FirstOrDefault(c => c.id.Equals(id));
            _context.SaveChanges();
            return VentaDatos;
        }
    }
}
