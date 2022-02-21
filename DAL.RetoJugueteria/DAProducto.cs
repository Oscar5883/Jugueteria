using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.RetoJugueteria
{
   public class DAProducto:Entities
    {
        private readonly Entities _jugueteriaEntities;
        public DAProducto(Entities jugueteriaEntities)
        {
            _jugueteriaEntities = jugueteriaEntities;

        }
        public List<Productos> ObtieneProdutos()
        {
            using (var db = _jugueteriaEntities)
            {
                return db.Productos.ToList();

            }


        }
        public Productos ObtineProducto(int id)
        {
            using (var db = _jugueteriaEntities)
            {
                return db.Productos.Where(x => x.Id == id).FirstOrDefault();

            }

        }
        public bool InsertaProducto(Productos productos)
        {
            bool Estatus = false;
            using (var db = _jugueteriaEntities)
            {
                db.Productos.Add(productos);
                db.SaveChanges();

                Estatus = true;
            }
            return Estatus;
        }
        public bool ActualizaProducto(int id, Productos productos)
        {
            bool Estatus = false;
            using (var db = _jugueteriaEntities)
            {
                var Producto = db.Productos.Where(x => x.Id == id).FirstOrDefault();
                Producto.Nombre = productos.Nombre;
                Producto.Compañia = productos.Compañia;
                Producto.Descripcion = productos.Descripcion;
                Producto.Precio = productos.Precio;
                Producto.RestriccionEdad = productos.RestriccionEdad;
                db.SaveChanges();
                Estatus = true;
            }
            return Estatus;
        }
        public bool EliminarProducto(int Id)
        {
            bool Estatus = false;
            using (var db = _jugueteriaEntities)
            {
                var Producto = db.Productos.Where(x => x.Id == Id).FirstOrDefault();
                if (Producto != null)
                {
                    db.Productos.Remove(Producto);
                    db.SaveChanges();
                    Estatus = true;
                }
                else
                {
                    Estatus = false;
                }
                return Estatus;
            }
        }
    }
}
