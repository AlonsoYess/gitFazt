using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class VentasxClientexMensualDetalleDatos
    {
        SqlConnection cnx;
        CompraEntidad muEntidad = new CompraEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public VentasxClientexMensualDetalleDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }
       
        public DataSet VxClienteDetalleDS(DateTime fechaInicio,DateTime fechaFin, string vendedor, string cliente,string empresa)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "pa_VentasMensualesXClienteYVenDe";
                cmd.Parameters.Add(new SqlParameter("@fechaInicio", fechaInicio));
                cmd.Parameters.Add(new SqlParameter("@fechaFin", fechaFin));
                cmd.Parameters.Add(new SqlParameter("@vendedor", vendedor));
                cmd.Parameters.Add(new SqlParameter("@cliente", cliente));
                cmd.Parameters.Add(new SqlParameter("@empresa", empresa));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "pa_VentasMensualesXClienteYVenDe");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }

            //return (dts.Tables["VentasMensualesGCDetalladoxCanal"]);
            return (dts);
        }

        public DataTable VxClienteDetalleDT(DateTime fechaInicio, DateTime fechaFin, string vendedor, string cliente, string empresa)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_VentasMensualesXClienteYVenDe";
                cmd.Parameters.Add(new SqlParameter("@fechaInicio", fechaInicio));
                cmd.Parameters.Add(new SqlParameter("@fechaFin", fechaFin));
                cmd.Parameters.Add(new SqlParameter("@vendedor", vendedor));
                cmd.Parameters.Add(new SqlParameter("@cliente", cliente));
                cmd.Parameters.Add(new SqlParameter("@empresa", empresa));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "pa_VentasMensualesXClienteYVenDe");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }

           return (dts.Tables["pa_VentasMensualesXClienteYVenDe"]);
            //return (dts);
        }
    }

}