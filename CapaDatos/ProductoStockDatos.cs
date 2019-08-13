using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class ProductoStockDatos
    {
        SqlConnection cnx;
        UsuarioEntidad muEntidad = new UsuarioEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public ProductoStockDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public DataTable ProductoStockListar(string parametro)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_stockConsulta";
                cmd.Parameters.Add(new SqlParameter("@var", parametro));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "ProductoStock");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["ProductoStock"]);
        }

    }

}