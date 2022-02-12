using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Data;

namespace Regla
{
    public class Rproducto
    {

        public static List<Producto> ListarPaginada(int PageSize, int PageNumber)
        { 
            List<Producto> productos = new List<Producto>();
            try
            {
                productos = Data.DProducto.ListarPaginada(PageSize, PageSize);
            }
            catch (Exception ex)
            {
                
            }
            return productos;
        }

        public static List<Producto> Listar()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                productos = Data.DProducto.Listar();
            }
            catch (Exception ex)
            {

            }
            return productos;
        }

        public static Producto Obtener(int codProducto)
        {
            Producto productos = new Producto();
            try
            {
                productos = Data.DProducto.Obtener(codProducto);
            }
            catch (Exception ex)
            {

            }
            return productos;
        }

        public static bool Registrar(Producto producto)
        {
            bool result = false;
            try
            {
                result = Data.DProducto.Registrar(producto);
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public static bool Modificar(Producto producto)
        {
            bool result = false;
            try
            {
                result = Data.DProducto.Modificar(producto);
            }
            catch (Exception ex)
            {

            }
            return result;
        }

        public static bool Eliminar(int codProducto)
        {
            bool result = false;
            try
            {
                result = Data.DProducto.Eliminar(codProducto);
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
} 
