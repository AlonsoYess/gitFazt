using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class ClienteDatos
    {
        SqlConnection cnx;
        CompraEntidad muEntidad = new CompraEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public ClienteDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }
       
        public DataTable ClienteConsultar(string dato)
        {

            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_ClienteConsultaDatos";
                cmd.Parameters.Add(new SqlParameter("@cli", dato));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "ClientesDetalle");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }

           

            return (dts.Tables["ClientesDetalle"]);

        }
    }

}