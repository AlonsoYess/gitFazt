using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class CotizacionDetDatos
    {
        SqlConnection cnx;
        CompraEntidad muEntidad = new CompraEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public CotizacionDetDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }
       
        public DataTable CotizacionDetConsultar(string vcot ,string vemp, string vdoc )
        {

            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_CotizacioDetalle";
                cmd.Parameters.Add(new SqlParameter("@cot", vcot));
                cmd.Parameters.Add(new SqlParameter("@emp", vemp));
                cmd.Parameters.Add(new SqlParameter("@doc", vdoc));


                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "paCotizacioDetalle");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }

           

            return (dts.Tables["paCotizacioDetalle"]);

        }
    }

}