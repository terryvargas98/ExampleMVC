using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExampleMVC.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ContextBD _con;
        public ProductoController(ContextBD con)
        {
            _con = con;
        }
        // GET: ProductoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProductoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductoController/Create
       
        public ActionResult ListarProductos()
        {
            ProductoDAO MiProductoDAO = new ProductoDAO(_con);
            List<Producto> MisProductos = MiProductoDAO.ListarProductos();

            return View(MisProductos);
        }

        // GET: ProductoController/Edit/5
        public ActionResult Comprar(int id)
        {
            return View();
        }

        // POST: ProductoController/Edit/5
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

        // GET: ProductoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductoController/Delete/5
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
