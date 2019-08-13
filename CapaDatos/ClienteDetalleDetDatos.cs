using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class ClienteDetalleDetDatos
    {
        SqlConnection cnx;
        CompraEntidad muEntidad = new CompraEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public ClienteDetalleDetDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public DataTable ClienteDetalleConsultarDET(string v1, string v2, string v3, string v4, string v5)
        {

            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "PA_VentaDetalladaXClienteDET";
                cmd.Parameters.Add(new SqlParameter("@v1", v1));
                cmd.Parameters.Add(new SqlParameter("@v2", v2));
                cmd.Parameters.Add(new SqlParameter("@v3", v3));
                cmd.Parameters.Add(new SqlParameter("@v4", v4));
                cmd.Parameters.Add(new SqlParameter("@v5", v5));

                SqlDataAdapter miada = new SqlDataAdapter(cmd);

                miada.Fill(dts, "ClienteDetalle");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["ClienteDetalle"]);

        }
    }

}