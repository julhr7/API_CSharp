using API_CSharp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API_CSharp.Data
{
    public class ProductoData
    {
        public static List<Producto> Listar()
        {
            List<Producto> oListaProductos = new List<Producto>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cn))
            {
                SqlCommand cmd = new SqlCommand("usp_productos_sel", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaProductos.Add(new Producto()
                            {
                                codProducto = Convert.ToInt32(dr["codProducto"]),
                                nomProducto = dr["nomProducto"].ToString(),
                                precioProducto = Convert.ToDecimal(dr["precioProducto"]),
                                fechRegistroProducto = dr["fechRegistroProducto"].ToString()
                            });
                        }
                    }
                    return oListaProductos;
                }
                catch (Exception ex)
                {
                    return oListaProductos;
                }
            }
        }

        public static Producto Obtener(int codProducto)
        {
            Producto oProducto = new Producto();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cn))
            {
                SqlCommand cmd = new SqlCommand("usp_productos_fnd", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codProducto", codProducto);
                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oProducto = new Producto()
                            {
                                codProducto = Convert.ToInt32(dr["codProducto"]),
                                nomProducto = dr["nomProducto"].ToString(),
                                precioProducto = Convert.ToDecimal(dr["precioProducto"]),
                                fechRegistroProducto = dr["fechRegistroProducto"].ToString()
                            };
                        }
                    }
                    return oProducto;
                }
                catch (Exception ex)
                {
                    return oProducto;
                }
            }
        }

        public static bool Registrar(Producto producto)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.cn))
            {
                SqlCommand cmd = new SqlCommand("usp_productos_ins", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nomProducto", producto.nomProducto);
                cmd.Parameters.AddWithValue("@precioProducto", producto.precioProducto);
                cmd.Parameters.AddWithValue("@fecha", producto.fechRegistroProducto);
                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static bool Modificar(Producto producto)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.cn))
            {
                SqlCommand cmd = new SqlCommand("usp_productos_upd", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codProducto", producto.codProducto);
                cmd.Parameters.AddWithValue("@nomProducto", producto.nomProducto);
                cmd.Parameters.AddWithValue("@precioProducto", producto.precioProducto);
                cmd.Parameters.AddWithValue("@fecha", producto.fechRegistroProducto);
                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static bool Eliminar(int codProducto)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.cn))
            {
                SqlCommand cmd = new SqlCommand("usp_productos_del", oConexion);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codProducto", codProducto);
                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}