using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;


namespace CapaDatos
{
    public class GuiaRemisionPendienteDatos
    {

        SqlConnection cnx;
        UsuarioEntidad muEntidad = new UsuarioEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public GuiaRemisionPendienteDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }

        public DataTable GuiaRemisionPendienteListarDT(DateTime fecha1, DateTime fecha2, string Serie, string Estado, string empresa)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_GuiaRemisionPendienteFacturar";
                cmd.Parameters.Add(new SqlParameter("@f1", fecha1));
                cmd.Parameters.Add(new SqlParameter("@f2", fecha2));
                cmd.Parameters.Add(new SqlParameter("@sr", Serie));
                cmd.Parameters.Add(new SqlParameter("@es", Estado));
                cmd.Parameters.Add(new SqlParameter("@empresa", empresa));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "LogisticaStockMin");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            return (dts.Tables["LogisticaStockMin"]);
        }
        public DataSet GuiaRemisionPendienteListarDS(DateTime fecha1, DateTime fecha2, string Serie, string Estado,string empresa)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_GuiaRemisionPendienteFacturar";
                cmd.Parameters.Add(new SqlParameter("@f1", fecha1));
                cmd.Parameters.Add(new SqlParameter("@f2", fecha2));
                cmd.Parameters.Add(new SqlParameter("@sr", Serie));
                cmd.Parameters.Add(new SqlParameter("@es", Estado));
                cmd.Parameters.Add(new SqlParameter("@empresa", empresa));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "LogisticaStockMin");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }
            //return (dts.Tables["LogisticaStockMin"]);
            return (dts);
        }

    }
}
