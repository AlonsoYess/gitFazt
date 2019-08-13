using System;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class ClienteDocDatos
    {
        SqlConnection cnx;
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public ClienteDocDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }
       
        public DataTable ClienteDocConsultar(string empresa, string ruc, string doc, string nro)
        {

            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_VentasMensualesGCorporativoxClientexDetalleDoc";

                cmd.Parameters.Add(new SqlParameter("@em", empresa));
                cmd.Parameters.Add(new SqlParameter("@cl", ruc));
                cmd.Parameters.Add(new SqlParameter("@dc", doc));
                cmd.Parameters.Add(new SqlParameter("@nr", nro));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Clientes");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["Clientes"]);

        }
    }

}