using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ExampleMVC.Controllers
{
    public class VentaController : Controller
    {
        // GET: VentaController
        private readonly ContextBD _con;
        
        private VentaDAO MiVentaDAO;
        private ProductoDAO ProductoDAO;
        private IConfiguration _configuration;
        public VentaController(ContextBD con)
        {
            _con = con;
           

                }


        [HttpPost]
        public ActionResult RegistrarVenta(string precioUnitario,string cantidad,string nombre,string idProducto)
        {

            MiVentaDAO = new VentaDAO(_con);
            Venta MiVenta = new Venta();
          
           
            MiVenta.calcularTotal(Convert.ToInt32(cantidad),Convert.ToInt32((precioUnitario)));
            

            MiVenta.registrarModel(DateTime.Now, Convert.ToInt32(idProducto));
            MiVentaDAO.RegistrarVentaRepository(MiVenta);

            return RedirectToAction("MostrarVenta",new { id = MiVenta.id });
        }
        public ActionResult RegistrarVenta(int ID)
        {
            ProductoDAO = new ProductoDAO(_con);
          Producto  MiProducto = ProductoDAO.BuscarProducto(ID);
            return View(MiProducto);
          
        }


        // GET: VentaController/Details/5
        public ActionResult MostrarVenta(int id)
        {
            MiVentaDAO = new VentaDAO(_con);
            ProductoDAO = new ProductoDAO(_con);
         Venta MiVENTA =  MiVentaDAO.BuscarVenta(id);
            Producto Producto1 = ProductoDAO.BuscarProducto(MiVENTA.id_producto);
            ViewBag.ProductoName = Producto1.nombre;
            return View(MiVENTA);
        }

        // GET: VentaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VentaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VentaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VentaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VentaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VentaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
