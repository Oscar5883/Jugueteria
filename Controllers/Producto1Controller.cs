using BL.RetoJugueteria;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RetoJugueteria.Controllers
{
    public class Producto1Controller : Controller
    {
        // GET: Producto1
        public ActionResult Index()
        {
            BlProducto Objproducto = new BlProducto();
            var Productos = Objproducto.ObtenerProductos();
            return View(Productos);
        }

        // GET: Producto1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Producto1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Producto1/Create
        [HttpPost]
        public ActionResult Create(EntidadProducto Producto)
        {
            try
            {
                BlProducto Objproducto = new BlProducto();
                var Productos = Objproducto.GuardaProducto(Producto);
               

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto1/Edit/5
        public ActionResult Edit(int id)
        {
            BlProducto Objproducto = new BlProducto();
            var Producto = Objproducto.ObtenerProducto (id);
            return View(Producto);
        }

        // POST: Producto1/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EntidadProducto producto)
        {
            try
            {

                // TODO: Add update logic here
                BlProducto Objproducto = new BlProducto();
                var Productos = Objproducto.EditarProducto(id,producto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Producto1/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [HttpPost]
        public JsonResult Eliminar(int id)
        {
            // TODO: Add update logic here
            BlProducto Objproducto = new BlProducto();
            var Productos = Objproducto.EliminarProducto(id);
            return Json(Productos,JsonRequestBehavior.AllowGet);
        }
    }
}
