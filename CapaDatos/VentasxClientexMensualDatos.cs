using System;
using System.Data;
using CapaEntidad;
using System.Data.SqlClient;
namespace CapaDatos
{
   public class VentasxClientexMensualDatos
    {
        SqlConnection cnx;
        CompraEntidad muEntidad = new CompraEntidad();
        Conexion MiConexi = new Conexion();
        SqlCommand cmd = new SqlCommand();
        public VentasxClientexMensualDatos()
        {
            cnx = new SqlConnection(MiConexi.GetConex());
        }
       
        public DataSet VentasGeneralesDetalleConsultarDS(DateTime fechaInicio, DateTime fechaFin, string vendedor, string empresa, string cliente)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;

                cmd.CommandText = "pa_VentasMensualesXClienteYVendedor";
                cmd.Parameters.Add(new SqlParameter("@fechaInicio", fechaInicio));
                cmd.Parameters.Add(new SqlParameter("@fechaFin", fechaFin));
                cmd.Parameters.Add(new SqlParameter("@vendedor", vendedor));
                cmd.Parameters.Add(new SqlParameter("@empresa", empresa));
                cmd.Parameters.Add(new SqlParameter("@cliente", cliente));


                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "pa_VentasMensualesXClienteYVendedor");
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

        public DataTable VentasGeneralesDetalleConsultarDT(DateTime fechaInicio, DateTime fechaFin, string vendedor, string empresa , string cliente)
        {
            DataSet dts = new DataSet();
            try
            {
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 0;
                cmd.CommandText = "pa_VentasMensualesXClienteYVendedor";
                cmd.Parameters.Add(new SqlParameter("@fechaInicio", fechaInicio));
                cmd.Parameters.Add(new SqlParameter("@fechaFin", fechaFin));
                cmd.Parameters.Add(new SqlParameter("@vendedor", vendedor));
                cmd.Parameters.Add(new SqlParameter("@empresa", empresa));
                cmd.Parameters.Add(new SqlParameter("@cliente", cliente));

                SqlDataAdapter miada;
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "pa_VentasMensualesXClienteYVendedor");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cmd.Parameters.Clear();
            }

           return (dts.Tables["pa_VentasMensualesXClienteYVendedor"]);
            //return (dts);
        }
    }

}