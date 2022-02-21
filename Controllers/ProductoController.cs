using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BL.RetoJugueteria;
using Entidades;



namespace RetoJugueteria.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        public ActionResult Index()
        {
           
            return View();
        }
       
    }
}