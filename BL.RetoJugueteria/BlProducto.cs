using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.RetoJugueteria;
using Entidades;

namespace BL.RetoJugueteria
{
   public class BlProducto
    {
        
        public List<EntidadProducto> ObtenerProductos()
        {
            try
            {
                DAProducto Objproducto = new DAProducto(new Entities());
                return productosMapper(Objproducto.ObtieneProdutos());

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool GuardaProducto(EntidadProducto producto)
        {
            bool Estatus = false;
            try
            {
                DAProducto Objproducto = new DAProducto(new Entities());

                Objproducto.InsertaProducto(MapearProducto(producto));
                Estatus = true;
            }
            catch (Exception)
            {

                Estatus = false;
            }
            return Estatus;
        }

        public bool EditarProducto(int id,EntidadProducto producto)
        {
            try
            {
                DAProducto Objproducto = new DAProducto(new Entities());

                Objproducto.ActualizaProducto(id,MapearProducto(producto));
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }
        public EntidadProducto ObtenerProducto(int id)
        {
            try
            {
                DAProducto Objproducto = new DAProducto(new Entities());
                return MapearObtenerProducto(Objproducto.ObtineProducto(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Resultado EliminarProducto(int id)
        {

            Resultado resultado = new Resultado();
            try
            {
              
                DAProducto Objproducto = new DAProducto(new Entities());

                if (Objproducto.EliminarProducto(id))
                {
                    resultado.MensajePersonalizado = "Producto eliminado correctamente";
                    resultado.MensajeSistema = "Producto eliminado correctamente";
                    resultado.Result = Result.OK;
                }
                else
                {
                    resultado.MensajePersonalizado = "El registro ya fue eliminado";
                    resultado.MensajeSistema = "El registro ya fue eliminado";
                    resultado.Result = Result.Error;
                }


            }
            catch (Exception ex)
            {
                
                resultado.MensajePersonalizado = "Erro en el sistema";
                resultado.MensajeSistema = ex.Message;
                resultado.Result = Result.Error;

            }
            return resultado;
        }
        private List<EntidadProducto> productosMapper(List<Productos> productos)
        {
            List<EntidadProducto> ListaObjetoProductos = new List<EntidadProducto>();
            foreach (var item in productos)
            {
                EntidadProducto ObjetoProducto = new EntidadProducto();
                ObjetoProducto.Compañia = item.Compañia;
                ObjetoProducto.Descripcion = item.Descripcion;
                ObjetoProducto.Nombre = item.Nombre;
                ObjetoProducto.Id = item.Id;
                ObjetoProducto.Precio = item.Precio;
                ObjetoProducto.RestriccionEdad = item.RestriccionEdad;
                ListaObjetoProductos.Add(ObjetoProducto);
            }
            return ListaObjetoProductos;
        }
        private Productos MapearProducto(EntidadProducto producto)
        {
            Productos ObjetoProducto = new Productos();
            ObjetoProducto.Compañia = producto.Compañia;
            ObjetoProducto.Descripcion = producto.Descripcion;
            ObjetoProducto.Id = producto.Id;
            ObjetoProducto.Nombre = producto.Nombre;
            ObjetoProducto.Precio = producto.Precio;
            ObjetoProducto.RestriccionEdad = producto.RestriccionEdad;

            return ObjetoProducto;

        }
        private EntidadProducto MapearObtenerProducto(Productos producto)
        {
            EntidadProducto ObjetoProducto = new EntidadProducto();
            ObjetoProducto.Compañia = producto.Compañia;
            ObjetoProducto.Descripcion = producto.Descripcion;
            ObjetoProducto.Id = producto.Id;
            ObjetoProducto.Nombre = producto.Nombre;
            ObjetoProducto.Precio = producto.Precio;
            ObjetoProducto.RestriccionEdad = producto.RestriccionEdad;

            return ObjetoProducto;
        }
    }
}
