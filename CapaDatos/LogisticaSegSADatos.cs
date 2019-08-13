using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class LogisticaSegSADatos
    {

        SqlConnection cnx;
        UsuarioEntidad muEntidad = new UsuarioEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public LogisticaSegSADatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public DataTable LogisticaSegSAListar(string fecha1, string fecha2, string almacen, string empresa)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_ControlDespachosAlmacen";

                cmd.Parameters.Add(new SqlParameter("@fec1", fecha1));
                cmd.Parameters.Add(new SqlParameter("@fec2", fecha2));
                cmd.Parameters.Add(new SqlParameter("@alm", almacen));
                cmd.Parameters.Add(new SqlParameter("@emp", empresa));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "DespachosAlmacen");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["DespachosAlmacen"]);
        }

    }
}
