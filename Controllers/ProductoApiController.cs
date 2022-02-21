using BL.RetoJugueteria;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RetoJugueteria.Controllers
{
    public class ProductoApiController : ApiController
    {
        // GET: api/ProductoApi
        [HttpGet]
        public IHttpActionResult GetProductos()
        {

            BlProducto Objproducto = new BlProducto();
            var Productos = Objproducto.ObtenerProductos();
            return Json(Productos);
        }

       
        
        // POST: api/ProductoApi
        public IHttpActionResult PostProducto([FromBody] EntidadProducto Producto)
        {
            BlProducto Objproducto = new BlProducto();
            var Productos = Objproducto.GuardaProducto(Producto);
            if (Productos == true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
           
        }

      
       
    }
}
