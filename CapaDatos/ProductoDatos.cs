using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class ProductoDatos
    {
        SqlConnection cnx;
        CompraEntidad muEntidad = new CompraEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public ProductoDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }
       
        public DataTable ProductoConsultar(string dato)
        {

            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_ProductoConsulta";
                cmd.Parameters.Add(new SqlParameter("@var", dato));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "ProductoDetalle");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["ProductoDetalle"]);

        }
    }

}